using UnityEngine;
using UnityEngine.UI;
using System;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] private Text scorePlayerText;
    [SerializeField] private Text scoreBotText;

    [SerializeField] public static int scorePlayer;
    [SerializeField] public static int scoreBot;

    private void Update()
    {
        scorePlayerText.text = Convert.ToString(scorePlayer);
        scoreBotText.text = Convert.ToString(scoreBot);
    }

    //Unity 2021.3.6f1
}