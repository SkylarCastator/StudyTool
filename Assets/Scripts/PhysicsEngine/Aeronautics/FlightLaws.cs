using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlightLaws : MonoBehaviour
{
    public float Lift(float liftCoefficent, float airDensity, float velocity, float wingSurfaceArea)
    {
        float lift = liftCoefficent * (0.5f * airDensity * Mathf.Pow(velocity, 2)) * wingSurfaceArea;
        return lift;
    }

    public float Weight(float liftCoefficent, float airDensity, float velocity, float wingSurfaceArea)
    {
        float lift = liftCoefficent * (0.5f * airDensity * Mathf.Pow(velocity, 2)) * wingSurfaceArea;
        return lift / Physics.Constants.gravity;
    }

    public float Drag(float dragCoefficent, float airDensity, float velocity, float wingSurfaceArea)
    {
        float drag = dragCoefficent * (0.5f * airDensity * Mathf.Pow(velocity, 2)) * wingSurfaceArea;
        return drag;
    }

    public float PtotTube(float pressureS, float airdensity, float volume)
    {
        float ptot = pressureS + (0.5f * airdensity * Mathf.Pow(volume, 2));
        return ptot;
    }

    public float GroundSpeed(float trueAirSpeed, float windSpeed, float windDirectionOffset)
    {
        float vX = windSpeed * Mathf.Sin(windDirectionOffset);
        float vY = trueAirSpeed - windSpeed * Mathf.Cos(windDirectionOffset);
        return Mathf.Sqrt(Mathf.Pow(vX, 2) * Mathf.Pow(vY, 2));
    }

    public float TrueAirSpeed()
    {
        return 0;
    }
}
