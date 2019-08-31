using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Physics.AeroNautics
{
    public static class AeroNauticConversions
    {
        public static float FindMassFromLift(float lift)
        {
            return lift / Constants.gravity;
        }
    }
}
