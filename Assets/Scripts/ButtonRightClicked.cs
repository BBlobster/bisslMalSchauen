using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonRightClicked : MonoBehaviour {

    public Transform player;

    /* Moves the player 20Px to the right (inside the screenspace Canvas thats 20% of the width)
     */
    private void OnMouseDown()
    {
        var pos = Camera.main.WorldToViewportPoint(transform.position);
        pos.x = Mathf.Clamp(pos.x,0,1);
        transform.position = Camera.main.ViewportToWorldPoint(pos);

        player.transform.localPosition = player.transform.localPosition + new Vector3(20, 0, 0);
    }
}
