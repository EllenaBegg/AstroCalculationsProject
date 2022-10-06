using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Student:     Ellena Begg, 30040389
 * Date:        September 2022
 * Version:     1.1 Testing Version
 * Description: Client Form to connect to the AstroServer to do Astronomical calculations.
 *              UI must be customisable: change language, change colour
 */

namespace AstroClient
{
    public partial class AstroClientForm : Form
    {
        public AstroClientForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    ChannelFactory<IAstroContract> pipeFactory = new ChannelFactory<IAstroContract>(
            //        new NetNamedPipeBinding(),
            //        new EndpointAddress("net.pipe://localhost/AstroCalculations"));

            //    IAstroContract pipeProxy = pipeFactory.CreateChannel();

            //    double owl = Double.Parse(textBox1.Text);
            //    double rwl = Double.Parse(textBox2.Text);

            //    double answer = pipeProxy.StarVelocity(owl, rwl);

            //    textBox3.Text = answer.ToString();
            //}
            //catch (Exception exc)
            //{
            //    MessageBox.Show("Error in connecting to server" + exc.Message);
            //}



        }

        #region Event Handlers

        /// <summary>
        /// Option to change the background colour of the form. User to select a custom colour from a colour palette (Color Dialogbox)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backgroundColourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colourDialog = new ColorDialog();
            if (colourDialog.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = colourDialog.Color;

                foreach (TabPage tabPage in this.tabControlOptions.TabPages)
                {
                    tabPage.BackColor = colourDialog.Color; // for each tab b/ground
                }

                listViewResults.BackColor = colourDialog.Color; // for listview b/ground
            }
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeLanguage("English");
        }

        private void frenchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeLanguage("French");
        }

        private void germanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeLanguage("German");
        }

        /// <summary>
        /// Change the style of the application to be Light (Black Text on White background)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            this.ForeColor = Color.Black;

            foreach (TabPage tabPage in this.tabControlOptions.TabPages)
            {
                tabPage.BackColor = Color.White; // for each tab
                tabPage.ForeColor = Color.Black;
            }

            listViewResults.BackColor = Color.White; // for listview
            listViewResults.ForeColor = Color.Black;

            foreach (Button button in Controls.OfType<Button>())
            {
                button.ForeColor = Color.Black;
            }
        }

        /// <summary>
        /// Change the style of the application to be Dark (White Text on Dark Gray background)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void darkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.DimGray;
            this.ForeColor = Color.WhiteSmoke;

            foreach (TabPage tabPage in this.tabControlOptions.TabPages)
            {
                tabPage.BackColor = Color.DimGray; // for each tab
                tabPage.ForeColor = Color.WhiteSmoke;
            }

            listViewResults.BackColor = Color.DimGray; // for listview
            listViewResults.ForeColor = Color.WhiteSmoke;

            foreach (Button button in Controls.OfType<Button>())
            {
                button.ForeColor = Color.WhiteSmoke;
            }
        }

        /// <summary>
        /// Open connection to the Server to use the dll for Calculations. 
        /// The Calculation we call is dependent on which Tab they have entered input into.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                ChannelFactory<IAstroContract> pipeFactory = new ChannelFactory<IAstroContract>(
                    new NetNamedPipeBinding(),
                    new EndpointAddress("net.pipe://localhost/AstroCalculations"));

                IAstroContract pipeProxy = pipeFactory.CreateChannel();

                if (tabControlOptions.SelectedTab == tabPageStarVelocity)
                {
                    CalculateStarVelocity(pipeProxy);
                }
                else if (tabControlOptions.SelectedTab == tabPageStarDistance)
                {
                    CalculateStarDistance(pipeProxy);
                }
                else if (tabControlOptions.SelectedTab == tabPageTemperature)
                {
                    labelCelsiusError.Visible = false;
                    // check values
                    if (Double.Parse(textBoxCelsius.Text) < -273)
                    {
                        labelCelsiusError.Visible = true;
                        return;
                    }
                    CalculateKelvin(pipeProxy);
                }
                else
                {
                    CalculateEventHorizon(pipeProxy);
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error in connecting to server" + exc.Message);
            }
        }

        /// <summary>
        /// CLear all textboxes, the listview and error message
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonClear_Click(object sender, EventArgs e)
        {
            listViewResults.Items.Clear();
            textBoxArcsecondsAngle.Clear();
            textBoxBaseNo.Clear();
            textBoxCelsius.Clear();
            textBoxExponetialNo.Clear();
            textBoxObservedWL.Clear();
            textBoxRestWL.Clear();
            labelCelsiusError.Visible = false;
        }
        #endregion


        #region Utility Methods
        /// <summary>
        /// Change the language of all items to selected language
        /// </summary>
        /// <param name="language">The language you want to change to</param>
        private void ChangeLanguage(string language)
        {
            switch (language)
            {
                case "English":
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-GB");
                    break;
                case "French":
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("fr-FR");
                    break;
                case "German":
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("de-DE");
                    break;
            }
            Controls.Clear();
            InitializeComponent();
        }

        /// <summary>
        /// Calculate the Star Velocity based on input provided for the Observed Wavelength and the Rest Wavelength.
        /// </summary>
        /// <param name="pipeProxy">Connection to the Server</param>
        private void CalculateStarVelocity(IAstroContract pipeProxy)
        {
            double owl = Double.Parse(textBoxObservedWL.Text);
            double rwl = Double.Parse(textBoxRestWL.Text);

            double result = pipeProxy.StarVelocity(owl, rwl);

            string answer = "";

            if ((result / 1000) >= 1)
            {
                double answerinKM = result / 1000;
                answer = String.Format("{0:#,#.##}", answerinKM) + " km/s";
            }
            else
            {
                answer = String.Format("{0:#,#.##}", result) + " m/s";
            }

            // display result in ListView
            string[] row = {
                        answer, "", "", ""
                    };
            listViewResults.Items.Add(new ListViewItem(row));
        }

        /// <summary>
        /// Calculate the Star Distance based on input of the Arc Seconds Angle.
        /// </summary>
        /// <param name="pipeProxy">Connection to the Server</param>
        private void CalculateStarDistance(IAstroContract pipeProxy)
        {
            double arcs = Double.Parse(textBoxArcsecondsAngle.Text);

            double result = pipeProxy.StarDistance(arcs);

            string answer = String.Format("{0:#,#.##}", result);
            string display = answer + " parsecs";
            // display result in ListView
            string[] row = {
                        "", display, "", ""
                    };
            listViewResults.Items.Add(new ListViewItem(row));
        }

        /// <summary>
        /// Calculate the degrees in Kelvin based on input of the degrees in Celsius.
        /// </summary>
        /// <param name="pipeProxy">Connection to the Server</param>
        private void CalculateKelvin(IAstroContract pipeProxy)
        {
            double celsius = Double.Parse(textBoxCelsius.Text);

            double result = pipeProxy.TemperatureInKelvin(celsius);

            string answer = String.Format("{0:#,#.##}", result);
            string display = answer + " Kelvin";
            // display result in ListView
            string[] row = {
                        "", "", display, ""
                    };
            listViewResults.Items.Add(new ListViewItem(row));
        }

        /// <summary>
        /// Calculate the Event Horizon based on mass of the object, which is calculated by the given input of the Base Number and the Exponential number
        /// </summary>
        /// <param name="pipeProxy"></param>
        private void CalculateEventHorizon(IAstroContract pipeProxy)
        {
            double baseNo = Double.Parse(textBoxBaseNo.Text);
            double exponentialNo = Double.Parse(textBoxExponetialNo.Text);
            double mass = baseNo * Math.Pow(10, exponentialNo);

            double result = pipeProxy.EventHorizon(mass);

            string answer = String.Format("{0:#.##E+0}", result);
            //MessageBox.Show(answer + " m"); //in meters

            //string answerSFkm = String.Format("{0:#.##E+0}", result / 1000);
            //MessageBox.Show(answerSFkm + " km"); //in kilometers

            string display = answer + " m";
            // display result in ListView
            string[] row = {
                        "", "", "", display
                    };
            listViewResults.Items.Add(new ListViewItem(row));
        }
        #endregion

        private void tabControlOptions_Click(object sender, EventArgs e)
        {
            labelCelsiusError.Visible = false;
        }
    } // end class
} // end namespace
