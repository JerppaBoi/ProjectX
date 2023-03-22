using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private int score = 0;
    private int health = 5;

    public Text ScoreText;
    public Text HealthText;

    public GameObject DeathMenu;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (health == 0)
        {
            Time.timeScale = 0f;
            DeathMenu.SetActive(true);
        }

        ScoreText.text = "Score: " + score;
        HealthText.text = "Health: " + health;
    }

    public void AddScore(int points)
    {
        score += points;
        Debug.Log("Score: " + score);
    }

    public void AddHealth(int points)
    {
        health += points;
        Debug.Log("Health: " + health);
    }

    public void RestartGame()
    {
        score = 0;
        health = 5;
        SceneManager.LoadScene("Game");
        Time.timeScale = 1f;
    }
}
