﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemyMagnetIn : MonoBehaviour
{
    public float magnetPower ;
    public float reflectPower;
    public int magnetEffect;

    public float maxSpeed;
    public float minSpeed;
    private float speed;

    private Rigidbody rgbd;

    public float lifeTime;
    private float startLife;

    public GameObject blueModel;
    public GameObject redModel;

    public GameObject UIManager;
    
    Vector3 direction;

    void Start()
    {
        

        UIManager = GameObject.Find("UI Manager");

        if (Random.value <= 0.5f)
        {
            blueModel.SetActive(false);
            magnetEffect = 1;
        }
        else
        {
            redModel.SetActive(false);
            magnetEffect = -1;
            magnetPower = reflectPower;
        }

        speed = Random.Range(minSpeed, maxSpeed);
        rgbd = GetComponent<Rigidbody>();
        direction = Vector3.zero;
    }

    private void FixedUpdate()
    {
        Move();
    }

    void Update()
    {
        startLife += Time.deltaTime;

        if (startLife > lifeTime)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player")){
            Debug.Log("enculer");
            other.GetComponent<Rigidbody>().AddForce(((transform.position-other.transform.position)*magnetPower*Time.deltaTime)*magnetEffect);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            UIManager.GetComponent<UIManagerScript>().MinusFiveSeconds();
            Destroy(gameObject);
        }
    }

    public void TakeDamage()
    {

    }


    private void Move()
    {
        direction.z = -1;

        Vector3 pos = rgbd.position;
        pos.z += direction.z * speed * Time.deltaTime;

        transform.Translate(0, 0, direction.z * speed * Time.deltaTime);
    }
}
