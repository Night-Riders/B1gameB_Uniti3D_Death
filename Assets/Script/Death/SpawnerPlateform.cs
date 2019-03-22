using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerPlateform : MonoBehaviour {

    public GameObject UIManager;
    private UIManagerScript UIManagerScript;
    private float currentScore;
    public float score;
    private float scoreIncrease;
    public GameObject plateforme;

    // Use this for initialization
    void Start () {
        scoreIncrease = score;
        UIManagerScript = UIManager.GetComponent<UIManagerScript>();
    }
	
	// Update is called once per frame
	void Update () {

        currentScore = UIManagerScript.currentScoreValue;

        if (currentScore >= score)
        {
            Instantiate(plateforme, transform.position, Quaternion.identity);
            score += scoreIncrease;
        }
    }
}
