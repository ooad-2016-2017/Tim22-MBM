using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Meni : MonoBehaviour {

    public Button start;
    public Button quit;
	// Use this for initialization
	
	
    public void Play_Game()
    {
        SceneManager.LoadScene(1);
    }
    public void Quit_Game()
    {
        Application.Quit();
    }
}
