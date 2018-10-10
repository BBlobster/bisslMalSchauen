using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* Sets the Timescale to 0 or 1 and calls the HideMe Script of all blocks to make them invisible
 */

public class ButtonPauseClicked : MonoBehaviour {

    private bool paused = false;

    /*The blockgenerator from the gameobject Blocks. See Editor.
     */
    public BlockGenerator blockGenerator;



    private void OnMouseDown()
    {
        /* Showing or hiding each block 
         */
        for (int i = 0; i < blockGenerator.Blocks.Count; i++)
        {
            GameObject showOrHideMe = blockGenerator.Blocks[i];
            if (showOrHideMe)
            {
                if (paused)
                {
                    showOrHideMe.GetComponent<HideOnPause>().Show();
                }
                else
                {
                    showOrHideMe.GetComponent<HideOnPause>().Hide();
                }
            }
            else { Debug.Log("block number: " + i + "does not exist anymore"); }
        }
        /* starts or pause the game by setting the timescale to 1 or 0
         */
        if (paused)
        {
            Time.timeScale = 1;
            paused = false;
        } 
        else 
        { 
            Time.timeScale = 0;
            paused = true;
        }
    }


}
