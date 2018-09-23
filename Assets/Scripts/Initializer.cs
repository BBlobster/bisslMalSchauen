using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Initializer : MonoBehaviour {

	// Use this for initialization
	void Start () {
        DontDestroyOnLoad(gameObject);
        DataManager.InitialLoad();
        SceneManager.LoadScene(1);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
