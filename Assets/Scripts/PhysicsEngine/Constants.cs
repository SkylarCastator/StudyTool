using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Physics
{
    public static class Constants
    {
        public const float gravity = 9.80665f;
        public const float speedOfLightInVacuum = 299792458; // (m/s)

        public static float StandardAtmosphere()
        {
            return 101325;
        }

        public static float PlanksConstant()
        {
            return ReturnStandardNotation(6.67430f, -11);
        }

        public static float hc()
        {
            return ReturnStandardNotation(6.67430f, -11);
        }

        public static float ReturnStandardNotation(float value, float shift)
        {
            return value * (Mathf.Pow(value, shift));
        }
    }
}

