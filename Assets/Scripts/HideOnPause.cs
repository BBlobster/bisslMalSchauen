using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideOnPause : MonoBehaviour {


	public void hide()
    {
            gameObject.GetComponent<Renderer>().enabled = false;
    }

    public void show()
    {
        gameObject.GetComponent<Renderer>().enabled = true;
    }

}
