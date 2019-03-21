using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class decorsDispawn : MonoBehaviour {

    private GameObject player;
    private Transform playerTransform;

    // Use this for initialization
    void Start () {
        player = GameObject.Find("Player");
        playerTransform = player.transform;
    }
	
	// Update is called once per frame
	void Update () {
		if ((playerTransform.position.z + 50 ) > transform.position.x)
        {
            Destroy(gameObject);
        }
	}
}
