using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class decorsSpawner : MonoBehaviour {

    public GameObject[] decors;
    public Transform parentTransform;
	// Use this for initialization
	void Start () {
        InvokeRepeating("SpawnDecors", 0f, 0.5f);
        InvokeRepeating("SpawnDecors", 0f, 1f);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void SpawnDecors()
    {
        Instantiate(decors[UnityEngine.Random.Range(0, 3)], transform.GetChild(Random.Range(0, transform.childCount)).position, Quaternion.identity);
    }
}