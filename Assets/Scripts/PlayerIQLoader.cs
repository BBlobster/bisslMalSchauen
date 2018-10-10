using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/* Loads the PlayerIQ from the Datamanager and refreshes the textPlayerIQ label.
 */

public class PlayerIQLoader : MonoBehaviour {

    public Text textPlayerIQ;
    private int playerIQ;
	// Use this for initialization
	void Start () {
        
        playerIQ = DataManager.PlayerIQ;
        textPlayerIQ.text = playerIQ.ToString();
    }

}
