using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockGenerator : MonoBehaviour {
    public GameObject prefabBlock;
    public Transform parent;
    private GameObject block;
    private Rigidbody2D rb;

    private System.Random zufall;
    private int x, y,i, thrust;
    private static int numberBlocks;
    private static GameObject[] blocks;

    public BlockGenerator()
    {
    }



    // Use this for initialization
    void Start (){
        Time.timeScale = 1;
        numberBlocks = 30;
        blocks = new GameObject[numberBlocks];
        zufall = new System.Random();
        for (i = 1; i < numberBlocks; i++)
        {
            // y steuert die startposition und damit wann der Block aufschlägt. durch Abzug von 0 oder 1 
            // wird sicher gestellt, dass auch blöcke auf gleicher höhe starten könnten...theoretisch auch 5
            //aktuell kann es noch dazu kommen, dass blöcke übereinander landen

            y = i - zufall.Next(2);
            
            //x verteil die Blöcke zufällig auf die bahnen 1-5 (-2 bis +2, 0 it die mittlere Bahn)
            x = zufall.Next(-2, +3);
            

            block = Instantiate(prefabBlock, new Vector3(x: x*20, y: 60*y, z: 0), Quaternion.identity) as GameObject;
            block.transform.SetParent(parent, false);
            rb = block.GetComponent(typeof(Rigidbody2D)) as Rigidbody2D;
            thrust = -400;
            rb.AddForce(transform.up * thrust);
            blocks.SetValue(block,i-1);
        }
        //FinalBlock ist größer als die aus der Schleife
        block = Instantiate(prefabBlock, new Vector3(x: 0, y: 50* (y+1), z: 0), Quaternion.identity);
        block.transform.localScale = block.transform.localScale + new Vector3(90, 90, 1);
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

    public GameObject[] Blocks
    {
        get { return blocks; }
    }
}
