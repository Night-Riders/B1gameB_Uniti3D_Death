using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {


    public float TimerGame;
    public Text TimeGame;
    
    // Use this for initialization
    void Start () {
	
	}

    // Update is called once per frame
    void Update()
    {
        
    
    TimeGame.text = "Timer :" + TimerGame;
    TimerGame -= Time.deltaTime/ 2;
        if (TimerGame < 0)
        {
            Debug.Log("fin");
            Application.Quit();
        }
     
}

}
