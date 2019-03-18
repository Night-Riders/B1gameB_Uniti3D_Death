using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusObject : MonoBehaviour {


    public GameObject bonusPrefab;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter (Collider other)
    {
        UIManager uiManager = bonusPrefab.GetComponent<UIManager>();
        if (other.name == "Player")
        {
            uiManager.AddTenSeconds();
            Destroy(gameObject);

        }
       
    }










   /* {
        UIManager uiManager = col.gameObject.GetComponent<UIManager>();
        if (col.tag == "Collectible")
        {
            uiManager.AddTenSeconds();
            Destroy(PLayerCTRL);
        }
    }*/
  /*  private void OnCollisionEnter(Collision collision)
    {
        UIManager uiManager = collision.gameObject.GetComponent<UIManager>();
        if (collision.gameObject.CompareTag("Player"))
        { 
       
            Destroy(gameObject);
            uiManager.AddTenSeconds();
        }*/
    }

