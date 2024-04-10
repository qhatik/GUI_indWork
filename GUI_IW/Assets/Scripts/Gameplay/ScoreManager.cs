using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public int score;
    public TextMeshProUGUI scoreDisplay;
    private void Awake()
    {
        if(!PlayerPrefs.HasKey("S"))
        {
            PlayerPrefs.SetInt("S", 0);
        }
    }

    private void Start()
    {
        score = PlayerPrefs.GetInt("S");
    }
    private void Update()
    {
        scoreDisplay.text = score.ToString();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Ships"))
        {
            score++;
            PlayerPrefs.SetInt("S", score);
        }

    }
}
