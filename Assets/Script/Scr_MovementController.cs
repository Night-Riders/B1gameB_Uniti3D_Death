﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_MovementController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        var v3 = Input.mousePosition;
        v3.z = 15f;
        v3 = Camera.main.ScreenToWorldPoint(v3);
        transform.position = v3;
    }
}
