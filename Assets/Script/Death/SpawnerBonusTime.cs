using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerBonusTime : MonoBehaviour {

    public GameObject UIManager;
    private UIManagerScript UIManagerScript;
    private float currentScore;
    public float Score = 200;
    public GameObject bonusTime;
    public Transform positionsParent;

    // Use this for initialization
    void Start () {
        UIManagerScript = UIManager.GetComponent<UIManagerScript>();
    }
	
	// Update is called once per frame
	void Update () {

        currentScore = UIManagerScript.currentScoreValue;

        if (currentScore >= Score)
        {
            Instantiate(bonusTime, positionsParent.GetChild(Random.Range(0, positionsParent.childCount)).position, Quaternion.identity);
            Score += 200;
        }
    }
}
