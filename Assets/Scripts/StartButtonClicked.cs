using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartButtonClicked : MonoBehaviour {

    private SceneSwitch sceneSwitch;
    private GameObject gameManager;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	public void switchScene () {

        gameManager = GameObject.Find("GameManager");
        sceneSwitch = gameManager.GetComponent<SceneSwitch>();
        sceneSwitch.SceneChooser();
        

	}
}
