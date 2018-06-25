using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonRightClicked : MonoBehaviour {

    public Transform player;

	// Use this for initialization
	void Start () {
		
	}

    private void OnMouseDown()
    {
        player.SetPositionAndRotation(player.position + Vector3.right, Quaternion.identity);
        Debug.Log("ButtonLeftClicked");

    }

    // Update is called once per frame
    void Update () {
		
	}
}
