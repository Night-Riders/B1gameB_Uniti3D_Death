using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plateformDispawn : MonoBehaviour {

    public GameObject UIManager;
    private UIManagerScript UIManagerScript;
    private float currentScore;
    private float Score;

    // Use this for initialization
    void Start () {
        UIManager = GameObject.Find("UI Manager");
        UIManagerScript = UIManager.GetComponent<UIManagerScript>();
        currentScore = UIManagerScript.currentScoreValue;
        Score = currentScore + 150;
    }
	
	// Update is called once per frame
	void Update () {

        currentScore = UIManagerScript.currentScoreValue;

        if (currentScore > Score)
        {
            Destroy(gameObject);
        }
    }
}
