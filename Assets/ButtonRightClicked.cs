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



        player.transform.localPosition = player.transform.localPosition + new Vector3(20, 0, 0);

        Debug.Log("ButtonLRightClicked " +Screen.width);

    }

    // Update is called once per frame
    void Update () {
		
	}
}
