
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
        var pos = Camera.main.WorldToViewportPoint(transform.position);
        pos.x = Mathf.Clamp(pos.x, 0, 1);
        transform.position = Camera.main.ViewportToWorldPoint(pos);



        player.transform.localPosition = player.transform.localPosition + new Vector3 (-20, 0, 0);
        Debug.Log("ButtonLeftClicked"+Screen.width);

        

    }
}
