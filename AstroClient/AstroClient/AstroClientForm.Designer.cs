namespace AstroClient
{
    partial class AstroClientForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AstroClientForm));
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.frenchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.germanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.styleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundColourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControlOptions = new System.Windows.Forms.TabControl();
            this.tabPageStarVelocity = new System.Windows.Forms.TabPage();
            this.textBoxRestWL = new System.Windows.Forms.TextBox();
            this.textBoxObservedWL = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPageStarDistance = new System.Windows.Forms.TabPage();
            this.textBoxArcsecondsAngle = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPageTemperature = new System.Windows.Forms.TabPage();
            this.textBoxCelsius = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tabPageEventHorizon = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxExponetialNo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxBaseNo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listViewResults = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.labelCelsiusError = new System.Windows.Forms.Label();
            this.menuStrip2.SuspendLayout();
            this.tabControlOptions.SuspendLayout();
            this.tabPageStarVelocity.SuspendLayout();
            this.tabPageStarDistance.SuspendLayout();
            this.tabPageTemperature.SuspendLayout();
            this.tabPageEventHorizon.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            resources.ApplyResources(this.menuStrip2, "menuStrip2");
            this.menuStrip2.Name = "menuStrip2";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.languageToolStripMenuItem,
            this.styleToolStripMenuItem,
            this.backgroundColourToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            resources.ApplyResources(this.settingsToolStripMenuItem, "settingsToolStripMenuItem");
            // 
            // languageToolStripMenuItem
            // 
            this.languageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.englishToolStripMenuItem,
            this.frenchToolStripMenuItem,
            this.germanToolStripMenuItem});
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            resources.ApplyResources(this.languageToolStripMenuItem, "languageToolStripMenuItem");
            // 
            // englishToolStripMenuItem
            // 
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            resources.ApplyResources(this.englishToolStripMenuItem, "englishToolStripMenuItem");
            this.englishToolStripMenuItem.Click += new System.EventHandler(this.englishToolStripMenuItem_Click);
            // 
            // frenchToolStripMenuItem
            // 
            this.frenchToolStripMenuItem.Name = "frenchToolStripMenuItem";
            resources.ApplyResources(this.frenchToolStripMenuItem, "frenchToolStripMenuItem");
            this.frenchToolStripMenuItem.Click += new System.EventHandler(this.frenchToolStripMenuItem_Click);
            // 
            // germanToolStripMenuItem
            // 
            this.germanToolStripMenuItem.Name = "germanToolStripMenuItem";
            resources.ApplyResources(this.germanToolStripMenuItem, "germanToolStripMenuItem");
            this.germanToolStripMenuItem.Click += new System.EventHandler(this.germanToolStripMenuItem_Click);
            // 
            // styleToolStripMenuItem
            // 
            this.styleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lightToolStripMenuItem,
            this.darkToolStripMenuItem});
            this.styleToolStripMenuItem.Name = "styleToolStripMenuItem";
            resources.ApplyResources(this.styleToolStripMenuItem, "styleToolStripMenuItem");
            // 
            // lightToolStripMenuItem
            // 
            this.lightToolStripMenuItem.Name = "lightToolStripMenuItem";
            resources.ApplyResources(this.lightToolStripMenuItem, "lightToolStripMenuItem");
            this.lightToolStripMenuItem.Click += new System.EventHandler(this.lightToolStripMenuItem_Click);
            // 
            // darkToolStripMenuItem
            // 
            this.darkToolStripMenuItem.Name = "darkToolStripMenuItem";
            resources.ApplyResources(this.darkToolStripMenuItem, "darkToolStripMenuItem");
            this.darkToolStripMenuItem.Click += new System.EventHandler(this.darkToolStripMenuItem_Click);
            // 
            // backgroundColourToolStripMenuItem
            // 
            this.backgroundColourToolStripMenuItem.Name = "backgroundColourToolStripMenuItem";
            resources.ApplyResources(this.backgroundColourToolStripMenuItem, "backgroundColourToolStripMenuItem");
            this.backgroundColourToolStripMenuItem.Click += new System.EventHandler(this.backgroundColourToolStripMenuItem_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // tabControlOptions
            // 
            this.tabControlOptions.Controls.Add(this.tabPageStarVelocity);
            this.tabControlOptions.Controls.Add(this.tabPageStarDistance);
            this.tabControlOptions.Controls.Add(this.tabPageTemperature);
            this.tabControlOptions.Controls.Add(this.tabPageEventHorizon);
            resources.ApplyResources(this.tabControlOptions, "tabControlOptions");
            this.tabControlOptions.Name = "tabControlOptions";
            this.tabControlOptions.SelectedIndex = 0;
            this.tabControlOptions.Click += new System.EventHandler(this.tabControlOptions_Click);
            // 
            // tabPageStarVelocity
            // 
            this.tabPageStarVelocity.Controls.Add(this.textBoxRestWL);
            this.tabPageStarVelocity.Controls.Add(this.textBoxObservedWL);
            this.tabPageStarVelocity.Controls.Add(this.label6);
            this.tabPageStarVelocity.Controls.Add(this.label5);
            this.tabPageStarVelocity.Controls.Add(this.label4);
            resources.ApplyResources(this.tabPageStarVelocity, "tabPageStarVelocity");
            this.tabPageStarVelocity.Name = "tabPageStarVelocity";
            // 
            // textBoxRestWL
            // 
            resources.ApplyResources(this.textBoxRestWL, "textBoxRestWL");
            this.textBoxRestWL.Name = "textBoxRestWL";
            // 
            // textBoxObservedWL
            // 
            resources.ApplyResources(this.textBoxObservedWL, "textBoxObservedWL");
            this.textBoxObservedWL.Name = "textBoxObservedWL";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // tabPageStarDistance
            // 
            this.tabPageStarDistance.Controls.Add(this.textBoxArcsecondsAngle);
            this.tabPageStarDistance.Controls.Add(this.label8);
            this.tabPageStarDistance.Controls.Add(this.label7);
            resources.ApplyResources(this.tabPageStarDistance, "tabPageStarDistance");
            this.tabPageStarDistance.Name = "tabPageStarDistance";
            // 
            // textBoxArcsecondsAngle
            // 
            resources.ApplyResources(this.textBoxArcsecondsAngle, "textBoxArcsecondsAngle");
            this.textBoxArcsecondsAngle.Name = "textBoxArcsecondsAngle";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // tabPageTemperature
            // 
            this.tabPageTemperature.Controls.Add(this.labelCelsiusError);
            this.tabPageTemperature.Controls.Add(this.textBoxCelsius);
            this.tabPageTemperature.Controls.Add(this.label13);
            this.tabPageTemperature.Controls.Add(this.label9);
            resources.ApplyResources(this.tabPageTemperature, "tabPageTemperature");
            this.tabPageTemperature.Name = "tabPageTemperature";
            // 
            // textBoxCelsius
            // 
            resources.ApplyResources(this.textBoxCelsius, "textBoxCelsius");
            this.textBoxCelsius.Name = "textBoxCelsius";
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.Name = "label13";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // tabPageEventHorizon
            // 
            this.tabPageEventHorizon.Controls.Add(this.label12);
            this.tabPageEventHorizon.Controls.Add(this.textBoxExponetialNo);
            this.tabPageEventHorizon.Controls.Add(this.label11);
            this.tabPageEventHorizon.Controls.Add(this.textBoxBaseNo);
            this.tabPageEventHorizon.Controls.Add(this.label10);
            resources.ApplyResources(this.tabPageEventHorizon, "tabPageEventHorizon");
            this.tabPageEventHorizon.Name = "tabPageEventHorizon";
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            // 
            // textBoxExponetialNo
            // 
            resources.ApplyResources(this.textBoxExponetialNo, "textBoxExponetialNo");
            this.textBoxExponetialNo.Name = "textBoxExponetialNo";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // textBoxBaseNo
            // 
            resources.ApplyResources(this.textBoxBaseNo, "textBoxBaseNo");
            this.textBoxBaseNo.Name = "textBoxBaseNo";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // listViewResults
            // 
            this.listViewResults.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listViewResults.HideSelection = false;
            resources.ApplyResources(this.listViewResults, "listViewResults");
            this.listViewResults.Name = "listViewResults";
            this.listViewResults.UseCompatibleStateImageBehavior = false;
            this.listViewResults.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            resources.ApplyResources(this.columnHeader1, "columnHeader1");
            // 
            // columnHeader2
            // 
            resources.ApplyResources(this.columnHeader2, "columnHeader2");
            // 
            // columnHeader3
            // 
            resources.ApplyResources(this.columnHeader3, "columnHeader3");
            // 
            // columnHeader4
            // 
            resources.ApplyResources(this.columnHeader4, "columnHeader4");
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.BackColor = System.Drawing.Color.SteelBlue;
            resources.ApplyResources(this.buttonCalculate, "buttonCalculate");
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.UseVisualStyleBackColor = false;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.SlateGray;
            resources.ApplyResources(this.buttonClear, "buttonClear");
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // labelCelsiusError
            // 
            resources.ApplyResources(this.labelCelsiusError, "labelCelsiusError");
            this.labelCelsiusError.ForeColor = System.Drawing.Color.Red;
            this.labelCelsiusError.Name = "labelCelsiusError";
            // 
            // AstroClientForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.listViewResults);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tabControlOptions);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AstroClientForm";
            this.ShowIcon = false;
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.tabControlOptions.ResumeLayout(false);
            this.tabPageStarVelocity.ResumeLayout(false);
            this.tabPageStarVelocity.PerformLayout();
            this.tabPageStarDistance.ResumeLayout(false);
            this.tabPageStarDistance.PerformLayout();
            this.tabPageTemperature.ResumeLayout(false);
            this.tabPageTemperature.PerformLayout();
            this.tabPageEventHorizon.ResumeLayout(false);
            this.tabPageEventHorizon.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem frenchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem germanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem styleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem darkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backgroundColourToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControlOptions;
        private System.Windows.Forms.TabPage tabPageStarVelocity;
        private System.Windows.Forms.TextBox textBoxRestWL;
        private System.Windows.Forms.TextBox textBoxObservedWL;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPageStarDistance;
        private System.Windows.Forms.TextBox textBoxArcsecondsAngle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage tabPageTemperature;
        private System.Windows.Forms.TextBox textBoxCelsius;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabPage tabPageEventHorizon;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxExponetialNo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxBaseNo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listViewResults;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Label labelCelsiusError;
    }
}

