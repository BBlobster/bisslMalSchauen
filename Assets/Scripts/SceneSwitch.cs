using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour {

    private string miniGame;
    private Scene scene;

    public void SceneSwitcher(string miniGame)
    {
        SceneManager.LoadScene(miniGame);
    }
    public void SceneChooser()
    {
        scene = SceneManager.GetActiveScene();
        if (scene.name == "HomeScene")
        {
            miniGame = "BlockGame";
        }else
        {
            miniGame = "HomeScene";
        }

        SceneSwitcher(miniGame);


    }
}
