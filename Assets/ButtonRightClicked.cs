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
        var pos = Camera.main.WorldToViewportPoint(transform.position);
        pos.x = Mathf.Clamp(pos.x,0,1);
        transform.position = Camera.main.ViewportToWorldPoint(pos);
        player.SetPositionAndRotation(player.position + Vector3.right, Quaternion.identity);

        Debug.Log("ButtonLRightClicked");

    }

    // Update is called once per frame
    void Update () {
		
	}
}
