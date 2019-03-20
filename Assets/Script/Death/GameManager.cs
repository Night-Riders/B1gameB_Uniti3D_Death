using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public static GameManager Singleton;
    public GameObject GameOver;

    // Use this for initialization
    void Start () {
        if (Singleton != null)
        {
            Destroy(gameObject);
        }
        else
        {
            Singleton = this;
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Death()
    {
        Time.timeScale = 0;
        GameOver.SetActive(true);
    }
}
