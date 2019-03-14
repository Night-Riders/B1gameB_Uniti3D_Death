using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour {


    public GameObject menuPause;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            TogglePause();
        }

    }
    public void TogglePause()
    {
        menuPause.SetActive(!menuPause.activeSelf);
        if (!menuPause.activeSelf)
        {
            Time.timeScale = 1;
        }
        else if (menuPause.activeSelf)
        {
            Time.timeScale = 0;
            Debug.Log("salut");
        }
    }
    public void OnClickContinue()
    {
        TogglePause();
    }
    public void BackGame()
    {
        TogglePause();
    }
    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void QuitGame()
    {
        Application.Quit();
    }

}

