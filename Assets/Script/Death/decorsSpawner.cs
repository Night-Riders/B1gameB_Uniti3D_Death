using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class decorsSpawner : MonoBehaviour {

    public GameObject[] decors;
    public float scoreToGet;
    private float nextScore;
    private float currentScore;
    public UIManagerScript UIManager;

    // Use this for initialization
    void Start() {
        UIManager = UIManager.GetComponent<UIManagerScript>();
        nextScore = scoreToGet;
    }

    // Update is called once per frame
    void Update() {
        currentScore = UIManager.currentScoreValue;
        if (currentScore > nextScore)
        {
            Instantiate(decors[UnityEngine.Random.Range(0, 3)], transform.GetChild(Random.Range(0, transform.childCount)).position, Quaternion.Euler(new Vector3(0, Random.Range(0, 360), 0)));
            Instantiate(decors[UnityEngine.Random.Range(0, 3)], transform.GetChild(Random.Range(0, transform.childCount)).position, Quaternion.Euler(new Vector3(0, Random.Range(0, 360), 0)));
            Instantiate(decors[UnityEngine.Random.Range(0, 3)], transform.GetChild(Random.Range(0, transform.childCount)).position, Quaternion.Euler(new Vector3(0, Random.Range(0, 360), 0)));
            Instantiate(decors[UnityEngine.Random.Range(0, 3)], transform.GetChild(Random.Range(0, transform.childCount)).position, Quaternion.Euler(new Vector3(0, Random.Range(0, 360), 0)));
            Instantiate(decors[UnityEngine.Random.Range(0, 3)], transform.GetChild(Random.Range(0, transform.childCount)).position, Quaternion.Euler(new Vector3(0, Random.Range(0, 360), 0)));
            Instantiate(decors[UnityEngine.Random.Range(0, 3)], transform.GetChild(Random.Range(0, transform.childCount)).position, Quaternion.Euler(new Vector3(0, Random.Range(0, 360), 0)));
            Instantiate(decors[UnityEngine.Random.Range(0, 3)], transform.GetChild(Random.Range(0, transform.childCount)).position, Quaternion.Euler(new Vector3(0, Random.Range(0, 360), 0)));
            Instantiate(decors[UnityEngine.Random.Range(0, 3)], transform.GetChild(Random.Range(0, transform.childCount)).position, Quaternion.Euler(new Vector3(0, Random.Range(0, 360), 0)));
            Instantiate(decors[UnityEngine.Random.Range(0, 3)], transform.GetChild(Random.Range(0, transform.childCount)).position, Quaternion.Euler(new Vector3(0, Random.Range(0, 360), 0)));
            Instantiate(decors[UnityEngine.Random.Range(0, 3)], transform.GetChild(Random.Range(0, transform.childCount)).position, Quaternion.Euler(new Vector3(0, Random.Range(0, 360), 0)));

            nextScore += scoreToGet;
        }
    }
}