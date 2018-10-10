using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*GameController ist part of the Gamemanager object
 * It should handle the communication to the Minigams and provides BasicFunctions for them to be calles when Games are finished or need
 * Data. For example a Random Int to Load a specific Level for Both Users.
 */
public class GameController : MonoBehaviour {

    /* Is used to change Scenes
     */
    private SceneSwitch sceneSwitch;

    /* Is called by finished Minigames 
     * When Challenges are implemented it shoul call the SetPoint Function of the challenge.
    */
    public void GameOver(int points, string ChallengeID)
    {
        
        sceneSwitch = gameObject.GetComponent<SceneSwitch>();
        sceneSwitch.SceneChooser();
    }



}
