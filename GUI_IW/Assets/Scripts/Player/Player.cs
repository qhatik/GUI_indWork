using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float maxHeight;
    [SerializeField] float minHeight;
    [SerializeField] float Yincrement;
    Vector2 targetPos;

    public int health;
    public GameObject effect;
    public GameObject retryMenu;
    //public GameObject pauseGameMenu;
    [SerializeField] PauseMenu pauseMenu;

    public TextMeshProUGUI healthDisplay;

    private void Update()
    {
        healthDisplay.text = health.ToString();
        if (health <=0)
        {
            retryMenu.SetActive(true);
            // SceneManager.LoadScene("MainScene");
            // PlayerPrefs.DeleteKey("S");
        }


        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.W) && transform.position.y < maxHeight)
        {
            //Instantiate(effect, transform.position, Quaternion.identity);
            targetPos = new Vector2(transform.position.x, transform.position.y + Yincrement);
        }
        else if (Input.GetKeyDown(KeyCode.S) && transform.position.y > minHeight)
        {
            //Instantiate(effect, transform.position, Quaternion.identity);
            targetPos = new Vector2(transform.position.x, transform.position.y - Yincrement);
        }

        if (Input.GetKeyUp(KeyCode.Escape))
        {
            Debug.Log("Pressed");
            if (pauseMenu.PauseGame)
            {
                pauseMenu.Resume();
            }
            else
            {
                pauseMenu.Pause();
            }

        }

    }
}
