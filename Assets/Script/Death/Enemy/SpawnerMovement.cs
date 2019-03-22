using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerMovement : MonoBehaviour {

    public Transform playerTransform;
    public int distanceWithPlayer;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if ((playerTransform.position.z + distanceWithPlayer > transform.position.z))
        {
            transform.Translate(0, 0, +2);
        }
    }
}
