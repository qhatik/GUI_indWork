using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;
using TMPro;

public class RetryMenu : MonoBehaviour
{
    public TextMeshProUGUI scoreT;
    public ScoreManager sm;
    [SerializeField] MainMenu menu;
    bool youLost;

    private void Start()
    {
        scoreT.text = ("Your score: ") + sm.score.ToString();
    }

    private void Update()
    {   if (youLost)
        {         
           YouLost();
        }
    }

    void YouLost()
    {
        youLost = true;
        Time.timeScale = 0f;

    }

    public void RestartGame()
    {
        SceneManager.LoadScene("MainScene");
        menu.ResetData();
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
        menu.ResetData();
    }

}
