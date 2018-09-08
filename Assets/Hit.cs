using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hit : MonoBehaviour {

<<<<<<< HEAD
    private int thrust;
    public Rigidbody2D rb;
    public Animation animExplosion;
	// Use this for initialization
	void Start () {
        rb = GetComponent(typeof(Rigidbody2D)) as Rigidbody2D;
        animExplosion = GetComponent<Animation>();
=======
    public GameObject blockGenerator;
    private DynamischErzeugen dynamischErzeugen;
    private int counter;        
        


    // Use this for initialization
    void Start () {
        blockGenerator = GameObject.Find("BlockGenerator");
        dynamischErzeugen = (DynamischErzeugen)blockGenerator.GetComponent(typeof(DynamischErzeugen));
        ChangeText.instance.counterText.text = counter.ToString();

>>>>>>> e0af49aefb51ed458c93a2eb68bad02c33188cf8
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.name == "ScreenBottom")
        {
            Debug.Log(collision.gameObject.name);
            animExplosion.Play ("BlockExplosion");
            Destroy(this.gameObject);

            counter = dynamischErzeugen.NumberBlocks;
            


            ChangeText.instance.counterText.text = counter.ToString();
            Debug.Log("counter" +counter);
            Debug.Log("NumberBlocks: "+dynamischErzeugen.NumberBlocks);
            counter--;
            dynamischErzeugen.NumberBlocks = counter;
        }

    }

    // Update is called once per frame
    void Update () {
        
    }
}
