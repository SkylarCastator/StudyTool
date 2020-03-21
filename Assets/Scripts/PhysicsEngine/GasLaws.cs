using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Physics
{
    public class GasLaws
    {
        public float FindPressureOfGas(float volume, float moles, float temp)
        {
            float pressure = (moles * Physics.Constants.gasConstant * temp) / volume;
            return pressure;
        }

        public float EquationOfState(float density, float temp)
        {
            float pressure = (density * Physics.Constants.gasConstant * temp);
            return pressure;
        }
    }
}
