using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathPlay : MonoBehaviour {


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        var v3 = transform.position;
    //    if ( v3 < 0 )
            {
            Destroy(gameObject);
        }
		
	}
}
