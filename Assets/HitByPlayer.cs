﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitByPlayer : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            Debug.Log("WON");
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
