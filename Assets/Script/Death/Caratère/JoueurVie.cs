using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoueurVie : MonoBehaviour {

    public GameObject UIManager;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if ((transform.position.x < -25)||(transform.position.x > 25))
        {
            UIManager.GetComponent<UIManagerScript>().DeathScreen();
        }
	}
}
