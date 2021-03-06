﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_PlayerMovement : MonoBehaviour {

    public float movementSpeed;
    public float followSpeed;
    public float magnetPower;
    private GameObject child;
    public static GameObject player;
    public float boost;
    public int MagnetEffect;
    public GameObject redParticles;
    public GameObject blueParticles;

	// Use this for initialization
	void Start () {
        child = transform.GetChild(0).gameObject;
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        Vector3 mousePos = Camera.main.ScreenToViewportPoint(Input.mousePosition);
        mousePos.z = transform.position.z + 5;
        transform.Translate(new Vector3((mousePos.x -0.5f) *magnetPower*followSpeed, 0, 1*movementSpeed)*Time.deltaTime*Time.timeScale);
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (MagnetEffect == 1)
            {
                blueParticles.SetActive(false);
                redParticles.SetActive(true);
                MagnetEffect = -1;
            }
            else if (MagnetEffect == -1)
            {
                blueParticles.SetActive(true);
                redParticles.SetActive(false);
                MagnetEffect = 1;
            }

        }
    }

    public void MagnetIn(Vector3 posMagnetIn, float magnetPower)
    {
        transform.position = Vector3.MoveTowards(transform.position, posMagnetIn, magnetPower);
        Debug.Log("salut");
    }
}