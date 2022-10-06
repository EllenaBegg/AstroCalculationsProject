using System;

/*
 * Student:     Ellena Begg, 30040389
 * Date:        6 October 2022
 * Version:     1.2 Final Version
 * Description: Custom Library with four mathematical formulas to calculate: 
 *              Star Velocity, Star Distance, Temperature conversion from celsius to kelvin, and a blackholes Event Horizon
 */

namespace AstroCalculations
{
    public class Calculations
    {
        /// <summary>
        /// Calculate a stars velocity using the Doppler Shift.
        /// </summary>
        /// <param name="observedWavelength">Observed Wave Length of light emitted, in nanometres</param>
        /// <param name="restWaveLength">Rest, or normal, Wave Length of light emitted, in nanometres</param>
        /// <returns>The velocity, in metres per second</returns>
        public static double StarVelocity(double observedWavelength, double restWaveLength)
        {
            // Formula: velocity = (shift in wave length / normal wave length) * speed of light
            double c = 299792458; // speed of light
            double v; // velocity

            v = c * (observedWavelength - restWaveLength) / restWaveLength;
            return v;
        }

        /// <summary>
        /// Calculate a stars distance using the parallax angle based on the Arcseconds angle.
        /// </summary>
        /// <param name="arcSecondsAngle">The parallax angle, in arcseconds</param>
        /// <returns>The distance, in parsecs</returns>
        public static double StarDistance(double arcSecondsAngle)
        {
            // Formula: D = 1/P
            return 1 / arcSecondsAngle;
        }

        /// <summary>
        /// Calculate the degrees in Kelvin from the degrees in celsius
        /// </summary>
        /// <param name="celsius">The temperature, in degress celsius</param>
        /// <returns>The temperature, in Kelvin</returns>
        public static double TemperatureInKelvin(double celsius)
        {
            // K = C + 273
            double k = celsius + 273;

            return k;
        }

        /// <summary>
        /// Calculate the event horizon of a mass. Using the Schwarzchild Radius method.
        /// </summary>
        /// <param name="blackholeMass">The mass of the object, in kg</param>
        /// <returns>The event horizon, in metres</returns>
        public static double EventHorizon(double blackholeMass)
        {
            // R = (2GM) / C^2
            double G = 6.6743 * Math.Pow(10, -11);
            double c = 299792458; // speed of light

            return (2 * G * blackholeMass) / (c * c);
        }
    }
}
