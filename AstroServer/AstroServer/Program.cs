using System;
using System.ServiceModel;

/*
 * Student:     Ellena Begg, 30040389
 * Date:        September 2022
 * Version:     1.1 Test Version
 * Description: Console Server that calls my Custom Library "AstroCalculations".
 *              Clients make calls to this server to do astronomical calculations.
 */

namespace AstroServer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(AstroServer),
                new Uri[] { new Uri("net.pipe://localhost") }))
            {
                host.AddServiceEndpoint(typeof(IAstroContract), new NetNamedPipeBinding(), "AstroCalculations");
                host.Open();
                Console.WriteLine("Service is available.  " + "Press <ENTER> to exit.");
                Console.ReadLine();
                host.Close();
            }
        }
    }
}
