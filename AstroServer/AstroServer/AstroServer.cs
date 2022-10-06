using System.ServiceModel;
using AstroCalculations;

/*
 * Student:     Ellena Begg, 30040389
 * Date:        September 2022
 * Version:     1.1 Test Version
 * Description: Class to implement the IAstroCalculations interface. This calls the Custom Library "AstroCalculations".
 */

namespace AstroServer
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single, IncludeExceptionDetailInFaults = true)]
    internal class AstroServer : IAstroContract
    {
        double IAstroContract.EventHorizon(double blackholeMass)
        {
            return Calculations.EventHorizon(blackholeMass);
        }

        double IAstroContract.StarDistance(double arcSecondsAngle)
        {
            return Calculations.StarDistance(arcSecondsAngle);
        }

        double IAstroContract.StarVelocity(double observedWaveLength, double restWaveLength)
        {
            return Calculations.StarVelocity(observedWaveLength, restWaveLength);
        }

        double IAstroContract.TemperatureInKelvin(double celsius)
        {
            return Calculations.TemperatureInKelvin(celsius);
        }
    }
}
