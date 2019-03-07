using System;
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

	// Use this for initialization
	void Start () {
        child = transform.GetChild(0).gameObject;
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        Vector3 mousePos = Camera.main.ScreenToViewportPoint(Input.mousePosition);
        mousePos.z = transform.position.z + 5;
        transform.Translate(new Vector3((mousePos.x -0.5f) *magnetPower*followSpeed, 0, 1*movementSpeed)*Time.deltaTime);
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            movementSpeed += boost;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            movementSpeed -= 10;
        }
    }

    public void MagnetIn(Vector3 posMagnetIn, float magnetPower)
    {
        transform.position = Vector3.MoveTowards(transform.position, posMagnetIn, magnetPower);
        Debug.Log("salut");
    }
}