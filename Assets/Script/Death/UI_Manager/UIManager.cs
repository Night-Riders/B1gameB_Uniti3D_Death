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
    public float Score = 0.1f;
    private float currentScoreValue = 0f;
    public Text scoreText;

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
        currentScoreValue = Score;
        Time.timeScale = 1;

    }

    // Update is called once per frame
    void Update()
    {
        currentTimerValue -= Time.deltaTime;
        timeText.text = currentTimerValue.ToString("Time : " + " 0.0 " + "s");
        currentScoreValue = Time.deltaTime;
        scoreText.text = currentScoreValue.ToString("Score :");



    }
    public void AddTenSeconds()
    {
        currentTimerValue += 10f;
    }
}
   


