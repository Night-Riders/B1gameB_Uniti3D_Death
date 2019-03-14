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

<<<<<<< HEAD
=======
    public GameObject joueur;

>>>>>>> 1820c36b2c39b97799f553bb3673771c94041016
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
<<<<<<< HEAD
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
=======
    void Start() {
        currentTimerValue = timerValue;
    }

    // Update is called once per frame
    void Update() {
        currentTimerValue -= Time.deltaTime;
        timeText.text = currentTimerValue.ToString("Time : " + " 0.0 " + "s");
        IncrementScore();
        scoreText.text = (currentScoreValue/2).ToString("Score :" + " 0");
>>>>>>> 1820c36b2c39b97799f553bb3673771c94041016
    }
    public void AddTenSeconds()
        {
            currentTimerValue += 10f;
        }

    public void IncrementScore()
        {
        if (joueur.transform.position.z > currentScoreValue)
            {
                currentScoreValue = joueur.transform.position.z;
            }
        }
}
   


