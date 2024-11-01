using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogicScripts : MonoBehaviour
{
    [SerializeField] private int playerScore;
    [SerializeField] private Text scoreText; 
    [ContextMenu("Increase Score")]
    public void addScore()
    {
        playerScore++;
        scoreText.text = playerScore.ToString();
    }
}
