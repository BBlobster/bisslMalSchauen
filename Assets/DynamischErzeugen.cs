using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DynamischErzeugen : MonoBehaviour {
    public GameObject sprite;
    public Transform parent;
    public GameObject block;
    private Rigidbody2D rb;

    private System.Random zufall = new System.Random();
    private int x, y, thrust;
    private static int numberBlocks = 100;

    // Use this for initialization
    void Start (){
        Time.timeScale = 1;

        for (y = 1; y < numberBlocks; y++)
        {
            x = zufall.Next(-2, +3);
            block = Instantiate(sprite, new Vector3(x: x*20, y: 50*y, z: 0), Quaternion.identity);
            block.transform.SetParent(parent, false);
            rb = block.GetComponent(typeof(Rigidbody2D)) as Rigidbody2D;
            thrust = -400;
            rb.AddForce(transform.up * thrust);
        }

        block = Instantiate(sprite, new Vector3(x: 0, y: 50 * (y+1), z: 0), Quaternion.identity);
        block.transform.localScale = block.transform.localScale + new Vector3(90, Screen.height, 1);
        block.transform.SetParent(parent, false);
        rb = block.GetComponent(typeof(Rigidbody2D)) as Rigidbody2D;
        thrust = -400;
        rb.AddForce(transform.up * thrust);
    }

    // Update is called once per frame
    void Update () {

    }
    //getter Setter für die Anzahl der Blöcke
    public int NumberBlocks
    {
        get { return numberBlocks; }
        set { numberBlocks = value; }
    }
}
