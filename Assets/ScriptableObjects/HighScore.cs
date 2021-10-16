using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "HighScore", menuName = "ScriptableObjects/HighScore", order = 1)]

public class HighScore : ScriptableObject
{
    public int highScore;
    public string playerName;

    public void SetScore(int score)
    {
        highScore = score;
    }

    public void SetPlayerName(string name)
    {
        playerName = name;
    }
}
