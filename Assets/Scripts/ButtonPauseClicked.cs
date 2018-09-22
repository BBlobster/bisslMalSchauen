using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPauseClicked : MonoBehaviour {

    private bool paused = false;
    private BlockGenerator blockGenerator;

    private void Start()
    {
        blockGenerator = gameObject.AddComponent<BlockGenerator>();
    }

    private void OnMouseDown()
    {
        Debug.Log("Pause clicked");
        
        if (paused)
        {
            Time.timeScale = 1;
            Debug.Log(Time.timeScale);
            foreach (GameObject hideMe in blockGenerator.Blocks)
            {
                if (hideMe)
                {
                    hideMe.GetComponent<HideOnPause>().show();
                }
            }
            paused = false;
        } 
        else 
        { 
            Time.timeScale = 0;
            Debug.Log(Time.timeScale);

            foreach (GameObject hideMe in blockGenerator.Blocks)
            {
                if (hideMe)
                {
                    hideMe.GetComponent<HideOnPause>().hide();
                }
            }
            paused = true;
        }
    }


}
