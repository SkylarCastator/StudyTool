using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestionGenerator : MonoBehaviour
{
    public Text AnswerText;
    public Text QuestionText;

    public void Start()
    {
        NextQuestion();
    }

    public void NextQuestion()
    {
        StudyEngine.AeroStaticStudySubject subject = new StudyEngine.AeroStaticStudySubject();
        QuestionText.text = (subject.ReturnQuestion());
        AnswerText.text = (subject.SolveQuestion());
    }
}
