using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartButtonClicked : MonoBehaviour {

    private SceneSwitch sceneSwitch;
    private GameObject gameManager;

	/*gets the Gamemanager and calls the scenechooser, to start a minigame
     */
	public void SwitchScene () {

        gameManager = GameObject.Find("GameManager");
        sceneSwitch = gameManager.GetComponent<SceneSwitch>();
        sceneSwitch.SceneChooser();
	}
}
