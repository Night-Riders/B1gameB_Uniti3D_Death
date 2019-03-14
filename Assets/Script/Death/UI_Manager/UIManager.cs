using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UIManager : MonoBehaviour
{
    public static UIManager Singleton;

    public float timerValue = 30f;
    private float currentTimerValue = 0f;
    public Text timeText;

    private float currentScoreValue = 0f;
    public Text scoreText;

    public GameObject joueur;


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
        }

        public void IncrementScore()
        {
            if (joueur.transform.position.z > currentScoreValue)
            {
                currentScoreValue = joueur.transform.position.z;
            }
        }
    } 
   


