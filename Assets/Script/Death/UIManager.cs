using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {
    public static UIManager Singleton;
    public float timerValue = 30f;
    private float currentTimerValue = 0f;
    public Text timeText;
    private void Awake()
    {
        if(Singleton !=null)
            {
            Destroy(gameObject);
        }
        else
        {
            Singleton = this;
        }
    }
    // Use this for initialization
    void Start () {
        currentTimerValue = timerValue;
	}
	
	// Update is called once per frame
	void Update () {
        currentTimerValue -= Time.deltaTime;
        timeText.text = currentTimerValue.ToString("Time : "+ " 0.0 "+"s");
	}
    public void AddTenSeconds()
    {
        currentTimerValue += 10f;
    }
}
