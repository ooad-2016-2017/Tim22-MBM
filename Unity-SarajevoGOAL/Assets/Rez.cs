using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Rez : MonoBehaviour {

    public Text Score;
    public GameObject lopta;
    private int prvi = 0;
    private int drugi = 0;
    public static bool canAdd = true;
	// Use this for initialization
	void Start () {
        lopta = GameObject.Find("lopta");
	}
	
	// Update is called once per frame
	void Update () {
        if (lopta.transform.position.x >= 6.5f && canAdd)
        {
            canAdd = false;
            prvi++;
        }
        if (lopta.transform.position.x <= -6.5f && canAdd)
        {
            canAdd = false;
            drugi++;
        }

        if(prvi >= 7)
        {
            SceneManager.LoadScene(3);
        }
        if(drugi >= 7)
        {
            SceneManager.LoadScene(2);
        }
        Score.text = prvi.ToString() + " - " + drugi.ToString();

	}
}
