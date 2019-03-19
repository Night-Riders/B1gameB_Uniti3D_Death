using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SpawnerManager : MonoBehaviour {

    public GameObject ennemi;
    public Transform positionsParent;

    public float spawnInterval;
    private float spawnIntervalStart;
    private float timeFromStart = 0f;

    private float survivedTime = 0f;
    public GameObject UIManager;
    private UIManagerScript UIManagerScript;
    private float currentScore;
    private float Score = 100;
    public GameObject bonusTime;

    public float difficulty;

    // Use this for initialization
    void Start()
    {
        spawnIntervalStart = spawnInterval;
        UIManagerScript = UIManager.GetComponent<UIManagerScript>();
    }

    // Update is called once per frame
    void Update()
    {
        spawnInterval -= Time.deltaTime;

        if (spawnInterval <= 0)
        {
            GenerateEnemy();
            spawnIntervalStart -= (difficulty/100); 
            spawnInterval = spawnIntervalStart;
            Debug.Log(spawnInterval);
        }

        currentScore = UIManagerScript.currentScoreValue;

        if (currentScore >= Score)
        {
            Instantiate(bonusTime, positionsParent.GetChild(Random.Range(0, positionsParent.childCount)).position, Quaternion.identity);
            Score += 100;
        }

    }
    void GenerateEnemy()
    {
        Instantiate(ennemi, positionsParent.GetChild(Random.Range(0, positionsParent.childCount)).position, Quaternion.identity);
        Debug.Log("salut");
    }
}