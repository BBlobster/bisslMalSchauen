using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/* A Script of the Gamemanager to handle which Scene should be loaded
 */

public class SceneSwitch : MonoBehaviour {

    private string miniGame;
    private Scene scene;

    /* Should be used to handle the logic which scene should be loaded next
     * actually just switches from homescene to a minigame and back
     */
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
    /* Called to change the Scene 
    */
    private void SceneSwitcher(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
