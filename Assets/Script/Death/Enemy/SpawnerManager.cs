using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SpawnerManager : MonoBehaviour {

    public GameObject ennemi;
    public Transform positionsParent;
    public float spawnInterval;
    private float survivedTime = 0f;
    public GameObject UIManager;
    private UIManagerScript UIManagerScript;
    private float currentScore;
    private float fromLastScore = 200;
    public GameObject bonusTime;

    // Use this for initialization
    void Start()
    {
        InvokeRepeating("GenerateEnemy", 0f, spawnInterval);
        UIManagerScript = UIManager.GetComponent<UIManagerScript>();
    }

    // Update is called once per frame
    void Update()
    {

        currentScore = UIManagerScript.currentScoreValue;

        if (currentScore >= fromLastScore)
        {
            Instantiate(bonusTime, positionsParent.GetChild(Random.Range(0, positionsParent.childCount)).position, Quaternion.identity);
            fromLastScore += currentScore;
        }
    }
    void GenerateEnemy()
    {
        Instantiate(ennemi, positionsParent.GetChild(Random.Range(0, positionsParent.childCount)).position, Quaternion.identity);
        Debug.Log("salut");
    }
}