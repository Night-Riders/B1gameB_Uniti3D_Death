using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class UIManagerScript : MonoBehaviour
{
    public static UIManagerScript Singleton;

    public float timerValue = 30f;
    private float currentTimerValue = 0f;
    public Text timeText;

    public float currentScoreValue = 0f;
    public Text scoreText;
  
    public GameObject joueur ;
    public int Life = 5;
   
    public GameObject gameOverScreen;

    private void Awake()
    {
        if (Singleton != null)
        {
            Destroy(gameObject);
        }
        else
        {
            Singleton = this;
        }
    }
    // Use this for initialization

    void Start()
    {
        currentTimerValue = timerValue;
        Time.timeScale = 1;
        currentTimerValue = timerValue;
    }



    // Update is called once per frame

    public void AddTenSeconds()
    {
        currentTimerValue += 10f;
    }

        // Update is called once per frame
        void Update() {
            currentTimerValue -= Time.deltaTime;
            timeText.text = currentTimerValue.ToString("Time : " + " 0.0 " + "s");
            IncrementScore();
            scoreText.text = (currentScoreValue / 2).ToString("Score :" + " 0");
        DeathTime();
        if (joueur == null)
        {
            DeathScreen();
        }
    }

        public void IncrementScore()
        {
            if (joueur.transform.position.z > currentScoreValue)
            {
                currentScoreValue = joueur.transform.position.z;
            }

        }
    public void DeathTime()
    {

        if (currentTimerValue <= 0f)
        {
            DeathScreen();
            
        }
    }
    public void DeathScreen ()
    {
        gameOverScreen.SetActive(true);

        if (gameOverScreen.activeSelf)
        {
            Time.timeScale = 0;
        }
        else if (!gameOverScreen.activeSelf)
        {
            Time.timeScale = 1;
            Debug.Log("salut");
        }

    }
    public void LoadStart()
    {
        SceneManager.LoadScene(1);
    }
    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void QuitGame()
    {
        Application.Quit();
    }


} 
   


