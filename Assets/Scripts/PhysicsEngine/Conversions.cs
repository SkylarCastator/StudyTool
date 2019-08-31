using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Physics
{
    public static class Conversions
    {
        public static float CelsiusToKelvin(float temp)
        {
            return temp + 273.15f;
        }
    }
}
