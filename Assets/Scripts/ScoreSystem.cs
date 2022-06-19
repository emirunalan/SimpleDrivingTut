using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreSystem : MonoBehaviour
{

    [SerializeField] TMP_Text scoreText;
    [SerializeField] float scoreMultiplier = 1f;

    int scoreRint;
    float score;

    public const string HighScoreKey = "HighScore";



    // Update is called once per frame
    void Update()
    {
        score += Time.deltaTime * scoreMultiplier;
        scoreRint = Mathf.FloorToInt(score);

        scoreText.text = scoreRint.ToString();
    }


    private void OnDestroy()
    {
        int currentHighScore = PlayerPrefs.GetInt(HighScoreKey, 0);

        if(score > currentHighScore)
        {
            PlayerPrefs.SetInt(HighScoreKey, Mathf.FloorToInt(score));
        }
    }
}
