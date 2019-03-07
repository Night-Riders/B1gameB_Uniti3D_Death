using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusObject : MonoBehaviour {

    public GameObject PLayerCTRL;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider col)

    {
        if (col.tag == "Colectible")
        {
            Destroy(PLayerCTRL);
        }
    }
}
