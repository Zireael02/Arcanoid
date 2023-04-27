using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiManager : MonoBehaviour
{
    [SerializeField] Text scoreText;

    private int currentScore;

    void Update()
    {
        scoreText.text = currentScore.ToString();
    }

    public void IncreaseScore(int value)
    {
        currentScore += value;
    }
}
