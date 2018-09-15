using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideOnPause : MonoBehaviour {

	public void hide()
    {
        gameObject.SetActive(false);
    }

    public void show()
    {
        gameObject.SetActive(true);
    }

}
