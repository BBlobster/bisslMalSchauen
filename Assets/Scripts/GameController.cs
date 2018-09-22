using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {


    private SceneSwitch sceneSwitch;

    //GameOver regelt die Datenübergabe bei Abschluss eines Spiels. Dazu gehören Punktzahl. 
    //eindeutge GameID(welches Spiel, welcher spieler, wann liegt am Server unter der GameID), Stats
    public void GameOver(int points, string GameID)
    {

        PlayerPrefs.SetInt(GameID, points);
    
        sceneSwitch = gameObject.GetComponent<SceneSwitch>();
        sceneSwitch.SceneChooser();
    }



}
