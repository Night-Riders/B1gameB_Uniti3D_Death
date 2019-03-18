using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathPlay : MonoBehaviour {


    // Use this for initialization
    void Start () {
		
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
            LoadLevel();
        }
    }
    public void LoadLevel()
    {
        SceneManager.LoadScene(3);

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
