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



    // Update is called once per frame
    void Update()
    {
        score += Time.deltaTime * scoreMultiplier;
        scoreRint = Mathf.FloorToInt(score);

        scoreText.text = scoreRint.ToString();
    }
}
