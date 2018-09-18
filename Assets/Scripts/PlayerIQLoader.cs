using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerIQLoader : MonoBehaviour {

    public Text textPlayerIQ;
    private int playerIQ;
    private GameObject gameManager;
    private StatManager statManager;
	// Use this for initialization
	void Start () {
        gameManager = GameObject.Find("GameManager");
       // Debug.Log(GameObject.Find("GameManager").name);
        statManager = gameManager.GetComponent<StatManager>();
        playerIQ = statManager.PlayerIQ;
        Debug.Log("PlayerIQ :"+playerIQ);
        textPlayerIQ.text = playerIQ.ToString();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
