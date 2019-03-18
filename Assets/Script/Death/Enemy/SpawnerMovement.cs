using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerMovement : MonoBehaviour {

    public Transform playerTransform;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if ((playerTransform.position.z + 10 > transform.position.z))
        {
            transform.Translate(0, 0, +1);
        }
    }
}
