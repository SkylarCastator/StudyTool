using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StudyEngine
{
    public class StudySubject
    {
        public virtual string ReturnQuestion(){ return "";}
        public virtual string SolveQuestion() { return ""; }
    }
}