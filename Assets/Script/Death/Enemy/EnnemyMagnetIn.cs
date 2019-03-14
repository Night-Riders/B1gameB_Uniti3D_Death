using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemyMagnetIn : MonoBehaviour
{
    public float magnetPower ;
    public int magnetEffect;

    void Start()
    {

    }

    void Update()
    {

    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player")){
            other.GetComponent<Rigidbody>().AddForce(((transform.position-other.transform.position)*magnetPower*Time.deltaTime)*magnetEffect);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
    public void TakeDamage()
    {

    }
}
