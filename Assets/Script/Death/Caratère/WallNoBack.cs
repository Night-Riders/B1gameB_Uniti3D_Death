using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallNoBack : MonoBehaviour {

    public GameObject player;
    private Transform playerTransform;
    private float highDistance;

	// Use this for initialization
	void Start () {
        playerTransform = player.transform;
	}
	
	// Update is called once per frame
	void Update () {

		if (playerTransform.position.z > highDistance)
        {
            highDistance = playerTransform.position.z;
        }


	}
}
