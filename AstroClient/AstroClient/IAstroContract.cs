using System.ServiceModel;

/*
 * Student:     Ellena Begg, 30040389
 * Date:        6 October 2022
 * Version:     1.2 Final Version
 * Description: Service Contract interface for avialable methods in my Custom Library "AstroCalculations".
 */


namespace AstroClient
{
    [ServiceContract]
    public interface IAstroContract
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
