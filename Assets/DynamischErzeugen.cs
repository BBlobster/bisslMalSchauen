using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DynamischErzeugen : MonoBehaviour {
    public GameObject sprite;
    public Transform parent;
    public GameObject block;
    public Rigidbody2D rb;

    private System.Random zufall = new System.Random();
    private int x,y, thrust;
    // Use this for initialization
    void Start ()
    {
        for(y = 0; y < 100; y++)
        {
            x = zufall.Next(-2, +3);
            block = Instantiate(sprite, new Vector3(x: x*20, y: 50*y, z: 0), Quaternion.identity);
            block.transform.SetParent(parent, false);
        }
        
    }

    

    // Update is called once per frame
    void Update () {

    }
}
