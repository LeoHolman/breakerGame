using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreHandler : MonoBehaviour
{
    public HighScore highScore;
    // Start is called before the first frame update
    void Start()
    {
        UpdateHighScore(7, "Ian");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            UpdateHighScore(5, "Leo");
        }
        
    }

    public void UpdateHighScore(int score, string name)
    {
        if (highScore != null)
        {
            highScore.SetScore(score);
            highScore.SetPlayerName(name);
        }
    }
}
