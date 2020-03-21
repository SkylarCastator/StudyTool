using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Physics
{
    public class Atmosphere
    {
        public float HydrostaticEquationGeopotential(float height, float pressure)
        {
            float deltaPressure = -pressure * Physics.Constants.gravity * height;
            return deltaPressure;
        }

        public float HydrostaticEquationGeometric(float height, float pressure)
        {
            float deltaPressure = -pressure * Physics.Constants.gravity * height;
            return deltaPressure;
        }
    }
}
