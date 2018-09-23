using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerIQLoader : MonoBehaviour {

    public Text textPlayerIQ;
    private int playerIQ;
	// Use this for initialization
	void Start () {
        
        Debug.Log("PlayerIQ :"+playerIQ);
        playerIQ = DataManager.PlayerIQ;
        textPlayerIQ.text = playerIQ.ToString();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
