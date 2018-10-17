
using UnityEngine;
using UnityEngine.SceneManagement;
    /* First loaded script used for initial Loads
     */
public class Initializer : MonoBehaviour {

	/* set the Gamemanager to DontDestroyOnLoad
     * calls Datamanager for initialLoad
     * Calls Scenemanager to Load the Homescene
     */
	void Start () {
        DontDestroyOnLoad(gameObject);
        DataManager.InitialLoad();
        SceneManager.LoadScene("HomeScene");
    }

}
