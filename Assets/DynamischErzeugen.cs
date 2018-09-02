using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DynamischErzeugen : MonoBehaviour {
    public GameObject sprite;
    public Transform parent;
    // Use this for initialization
    void Start ()
    {
        Instantiate(sprite, new Vector3(x: 0, y: 50, z: 0), Quaternion.identity);
        sprite.transform.SetParent(parent, false);
    }



    // Update is called once per frame
    void Update () {
		
	}
}
