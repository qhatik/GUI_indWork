using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("MainScene");
        ResetData();
    }

    public void LoadGame()
    {
        if(PlayerPrefs.HasKey("S"))
        {
            SceneManager.LoadScene("MainScene");
            GetComponent<ScoreManager>().score = PlayerPrefs.GetInt("S");
        }
    }

   public void ExitGame()
    {
        Debug.Log("The Game Closed ");
        Application.Quit();
    }

   public void ResetData()
    {
       //PlayerPrefs.DeleteAll();
        PlayerPrefs.SetInt("S", 0);
    }
}
