
using UnityEngine;

public class ButtonLeftClicked : MonoBehaviour {

    public Transform player;

    /* Moves the player 20Px to the left (inside the screenspace Canvas thats 20% of the width)
     */
    private void OnMouseDown()
    {
        var pos = Camera.main.WorldToViewportPoint(transform.position);
        pos.x = Mathf.Clamp(pos.x, 0, 1);
        transform.position = Camera.main.ViewportToWorldPoint(pos);

        player.transform.localPosition = player.transform.localPosition + new Vector3 (-20, 0, 0);
        Debug.Log("ButtonLeftClicked"+Screen.width);
    }
}
