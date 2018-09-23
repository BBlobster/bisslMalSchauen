using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hit : MonoBehaviour {

    
    private BlockGenerator blockGenerator;
    private GameObject blocks;
    private int counter;
    private Animation explodeBlock;
    private Animator animator;
        


    // Use this for initialization
    void Start () {
        blocks = GameObject.Find("Blocks");
        blockGenerator = (BlockGenerator)blocks.GetComponent(typeof(BlockGenerator));
        ChangeText.instance.counterText.text = counter.ToString();
        animator = GetComponent<Animator>();

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Wenn der Block auf ScreenBottom stößt, dann Schalter für Destroy setzen, Destroyanimation starten, 
        //schauen wie viele Blöcke noch da sind, 1 abziehen, die Anzeige ändern, die neue Anzahl der Blöcke zurückschreiben
        if (collision.gameObject.name == "ScreenBottom")
        {
            Debug.Log(collision.gameObject.name);            
            
            animator.SetTrigger("destroy");
            Debug.Log(animator.IsInTransition(0).ToString());
            gameObject.GetComponent<Rigidbody2D>().velocity = Vector3.zero;

            counter = blockGenerator.NumberBlocks;
            counter--;
            ChangeText.instance.counterText.text = counter.ToString();
            blockGenerator.NumberBlocks = counter;
            Debug.Log(animator.IsInTransition(0).ToString());

            animator.SetTrigger("wrecked");


        }

    }

    // Update is called once per frame
    void Update () {       
    }
}
