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

    public float currentScoreValue = 0f;
    public Text scoreText;
  
    public GameObject joueur ;
    public int Life = 5;
   
    public GameObject gameOverScreen;
    public GameObject Slider;

    private Slider SliderUI;

    public AudioSource audioComponent;
    public AudioClip musicStart;
    public AudioClip musicLoop;
    public AudioClip GameOverSound;

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

        audioComponent.clip = musicStart;
    }



    // Update is called once per frame

    // Update is called once per frame
    void Update() {
        audioComponent.Play();

        if (currentTimerValue > 50f)
        {
            currentTimerValue = 50f;
        }

            currentTimerValue -= Time.deltaTime;
            IncrementScore();
            scoreText.text = (currentScoreValue / 2).ToString("0");
        DeathTime();
        if (joueur == null)
        {
            DeathScreen();
        }
        SliderFunction();
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


    public void AddTenSeconds()
    {
        currentTimerValue += 10f;
    }

    public void MinusFiveSeconds()
    {
        currentTimerValue -= 5f;
    }

    private void SliderFunction()
    {
        SliderUI = Slider.GetComponent<Slider>();
        SliderUI.value = currentTimerValue;
    }

} 
   


