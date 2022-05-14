using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePlayManager : MonoBehaviour
{
    public static GamePlayManager Instance = null;

    [SerializeField]
    private float roundTime = 30f;
    [SerializeField]
    private int scoreToWin = 5;

    public int Score = 0;
    public float TimeLeft = 0f;

    public bool IsGameOver = false;

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }

        TimeLeft = roundTime;
    }

    private void Update()
    {
        if (!IsGameOver)
            TimeLeft -= Time.deltaTime;
        else
            TimeLeft = 0;

        if (TimeLeft <= 0 && !IsGameOver)
        {
            GameOver();
            IsGameOver = true;
        }

        if(scoreToWin == Score && !IsGameOver)
        {
            GameOver();
            IsGameOver = true;
        }
    }

    private void GameOver()
    {
        if(scoreToWin == Score)
        {
            Win();
        }
        else
        {
            Lose();
        }
    }

    private void Win()
    {
        print("Win");
    }

    private void Lose()
    {
        print("Lose");
    }

}
