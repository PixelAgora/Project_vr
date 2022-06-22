using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    public TextMeshProUGUI scoreText;

    int score = 0;
    
    private void Awake(){
        instance = this;
    }
    void Start(){
        scoreText.text = "POINTS: " + score.ToString();
        
    }

    public void AddPoint(){
        score += 1;
        scoreText.text = "POINTS: " + score.ToString();
    }
}
