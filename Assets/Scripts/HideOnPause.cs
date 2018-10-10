using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* Behavior for GameObjects which should hide if the PauseButton is pressed
 * you can use a method which calls the Hide/Show method of each gameobject which has this behavior.
 */
public class HideOnPause : MonoBehaviour {


	public void Hide()
    {
        Debug.Log("hideme");
        gameObject.GetComponent<SpriteRenderer>().enabled = false;
    }

    public void Show()
    {
        gameObject.GetComponent<SpriteRenderer>().enabled = true;
    }

}
