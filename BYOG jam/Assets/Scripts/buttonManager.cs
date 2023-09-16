using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttonManager : MonoBehaviour
{
    public GameObject feedbackPanel;
    public Text feedbackText;

    // Called when the correct answer button is clicked
    public void CorrectAnswer()
    {
        ShowFeedback("Correct!", Color.green);
    }

    // Called when the wrong answer button is clicked
    public void WrongAnswer()
    {
        ShowFeedback("Wrong Answer", Color.red);
    }

    // Display feedback and change the color of the feedback panel text
    private void ShowFeedback(string message, Color color)
    {
        feedbackText.text = message;
        feedbackText.color = color;
        feedbackPanel.SetActive(true);
        Invoke("Reset", 2.0f);
    }

    // Called to reset the feedback panel for the next question
    public void Reset()
    {
        feedbackPanel.SetActive(false);
    }
}

