using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StudyEngine
{
    public class AeroStaticStudySubject : StudySubject
    {
        private const string subjectName = "Aerostatic Principles";
        private const string subjectType = "Physics";

        private string referencedQuestion = "This is a test Question";
        private string referencedAnswer = "This is a test Answer";

        private string[] referenceStrings = new string[] { "The volume of a hot air balloon is {0} cubic metres, and the temperature of the hot air is {1} degrees Celsius. Given these figures, and an outside air temperature and density of {2} ∘C and {3} kg/m3 respectively, compute the maximum mass (in kilograms) of the balloon, basket and payload." };

        public AeroStaticStudySubject()
        {
           
            Physics.AeroStatic.HotAirBalloon questionClass = new Physics.AeroStatic.HotAirBalloon();
            float volume = questionClass.RandomBalloonVolume();
            float atmosphereTemp = questionClass.RandomTempratureAtm();
            float balloonHeat = questionClass.RandomBalloonHeat();
            float lift = questionClass.FindLiftOFHotAirBalloon(1.225f, volume, atmosphereTemp, balloonHeat);

            referencedQuestion = referenceStrings[0];
            referencedQuestion = string.Format(referencedQuestion, volume, balloonHeat, atmosphereTemp, 1.225f);
            referencedAnswer = ("Lift : " + lift + " with the weight of : " + Physics.AeroNautics.AeroNauticConversions.FindMassFromLift(lift));

        }

        public override string ReturnQuestion()
        {
            return referencedQuestion;
        }

        public override string SolveQuestion()
        {
            return referencedAnswer;
        }
    }
}
