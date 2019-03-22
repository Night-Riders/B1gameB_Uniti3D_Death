using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SpawnerManager : MonoBehaviour {

    public GameObject ennemi;
    public Transform positionsParent;
    public GameObject parentSpawn;

    public float spawnInterval = 2;
    public float spawnIntervalStart;
    private float timeFromStart = 0f;

    private float survivedTime = 0f;
    public GameObject UIManager;
    private UIManagerScript UIManagerScript;
    private float currentScore;
    public float Score = 100;
    public GameObject bonusTime;

    public float difficulty;

    private bool isFinished = false;
    public GameObject SpawnerManagerPrefab;

    // Use this for initialization
    void Start()
    {
        spawnInterval = 2;
        UIManager = GameObject.Find("UI Manager");
        parentSpawn = GameObject.Find("ParentSpawner");
        positionsParent = parentSpawn.transform;
        spawnIntervalStart = spawnInterval;
        UIManagerScript = UIManager.GetComponent<UIManagerScript>();
    }

    // Update is called once per frame
    void Update()
    {
        spawnInterval -= Time.deltaTime;

        if (((spawnInterval <= 0.1f)))
        {
            GenerateEnemy();

            if (spawnIntervalStart >= 0.5f)
            {
                spawnIntervalStart -= (difficulty / 50f) * Time.deltaTime;
                spawnInterval = spawnIntervalStart;
            }
            spawnInterval = spawnIntervalStart;
            Debug.Log(spawnInterval);
        }

        if ((isFinished == false) && (spawnIntervalStart < 0.5))
        {
            Debug.Log("lol");
            spawnIntervalStart = 2;
            Instantiate(SpawnerManagerPrefab);
            isFinished = true;
        }

    }
    void GenerateEnemy()
    {
        Instantiate(ennemi, positionsParent.GetChild(Random.Range(0, positionsParent.childCount)).position, Quaternion.identity);
    }
}