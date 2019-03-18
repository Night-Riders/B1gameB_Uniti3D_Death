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

    // Use this for initialization
    void Start()
    {
        InvokeRepeating("GenerateEnemy", 0f, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
    }
    void GenerateEnemy()
    {
        Instantiate(ennemi, positionsParent.GetChild(Random.Range(0, positionsParent.childCount)).position, Quaternion.identity);

    }
}