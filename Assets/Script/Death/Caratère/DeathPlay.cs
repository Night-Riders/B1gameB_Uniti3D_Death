using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathPlay : MonoBehaviour {

    public GameObject gameManager;
    // Use this for initialization
    void Start () {
        gameManager = GameObject.Find("GameManager");
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // Application.LoadLevel(Application.loadedLevel);
            gameManager.GetComponent<GameManager>().Death();
        }
    }
  
   /* private void DeathPlayer ()
    {
        UIManager uiManager = gameObject.GetComponent<UIManager>();
            if(Life<0)
        {
            SceneManager.LoadScene(3);
        }
    }*/
}
