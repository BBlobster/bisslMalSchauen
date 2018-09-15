using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPauseClicked : MonoBehaviour {

    private bool paused = false;
    private HideOnPause[] hideThem;

    private void Start()
    {
    }

    private void OnMouseDown()
    {
        Debug.Log("Pause clicked");
       hideThem = Resources.FindObjectsOfTypeAll<HideOnPause>();
        if (paused)
        {
            Time.timeScale = 1;
            foreach (HideOnPause hideMe in hideThem)
            {
                hideMe.show();
                //print("jo" + hideThem);
            }
            paused = false;
        } 
        else 
        { 
            Time.timeScale = 0;
            foreach (HideOnPause hideMe in hideThem)
            {
                //print("joho" + hideThem);
                hideMe.hide();
            }
            paused = true;
        }
    }


}
