
using UnityEngine;

public class ButtonLeftClicked : MonoBehaviour {

    public Transform player;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnMouseDown()
    {

        

        player.SetPositionAndRotation(player.position+Vector3.left,Quaternion.identity);
        Debug.Log("ButtonLeftClicked");

    }
}
