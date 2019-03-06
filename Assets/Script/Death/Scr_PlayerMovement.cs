using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_PlayerMovement : MonoBehaviour {

    public float movementSpeed;

    private GameObject child;

	// Use this for initialization
	void Start () {
        child = transform.GetChild(0).gameObject;
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        Vector3 mousePos = Camera.main.ScreenToViewportPoint(Input.mousePosition);
        mousePos.z = transform.position.z + 5;
        transform.Translate(new Vector3((mousePos.x -0.5f) *5, 0, 1*movementSpeed)*Time.deltaTime);
        Debug.Log(mousePos);
    }
}