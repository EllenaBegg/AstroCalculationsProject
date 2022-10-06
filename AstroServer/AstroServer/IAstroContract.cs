using System.ServiceModel;

/*
 * Student:     Ellena Begg, 30040389
 * Date:        September 2022
 * Version:     1.1 Test Version
 * Description: Service Contract interface for avialable methods in my Custom Library "AstroCalculations".
 */

namespace AstroServer
{
    [ServiceContract]
    internal interface IAstroContract
    {
        [OperationContract]
        double StarVelocity(double observedWaveLength, double restWaveLength);

        [OperationContract]
        double StarDistance(double arcSecondsAngle);

        [OperationContract]
        double TemperatureInKelvin(double celsius);

        [OperationContract]
        double EventHorizon(double blackholeMass);
    }
}
