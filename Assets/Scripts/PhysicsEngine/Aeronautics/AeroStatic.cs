using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Physics
{
    public class AeroStatic
    {
        public class GasBalloon : AeroStatic
        {
            public float FindLiftOFGasBalloon(float densityATM, float balloonVolume, float moleMassATM, float moleMassGas)
            {
                float lift = densityATM * balloonVolume * Constants.gravity * (1 - (moleMassGas / moleMassATM));
                return lift;
            }

            
        }

        public class HotAirBalloon : AeroStatic
        {
            /// <summary>
            /// Find lift of a hot air balloon
            /// </summary>
            /// <param name="densityATM"></param>
            /// <param name="balloonVolume"></param>
            /// <param name="tATM"></param>
            /// <param name="t"></param>
            /// <returns></returns>
            public float FindLiftOFHotAirBalloon(float densityATM, float balloonVolume, float tempratureATM, float tempratureHotAir)
            {
                float lift = densityATM * balloonVolume * Constants.gravity * ((tempratureHotAir - tempratureATM) / Conversions.CelsiusToKelvin(tempratureHotAir));
                return lift;
            }

            public float RandomBalloonHeat()
            {
                return Random.Range(75, 120);
            }

            public float RandomBalloonVolume()
            {
                return Random.Range(0.5f, 400);
            }

            public float RandomTempratureAtm()
            {
                return Random.Range(-20, 35);
            }
        }
    }
}
