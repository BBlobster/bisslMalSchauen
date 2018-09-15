using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hit : MonoBehaviour {

    public GameObject blockGenerator;
    private DynamischErzeugen dynamischErzeugen;
    private int counter;
    private bool destroyMe = false;
    private Animation explodeBlock;
    private Animator animator;
        


    // Use this for initialization
    void Start () {
        blockGenerator = GameObject.Find("BlockGenerator");
        dynamischErzeugen = (DynamischErzeugen)blockGenerator.GetComponent(typeof(DynamischErzeugen));
        ChangeText.instance.counterText.text = counter.ToString();
        animator = GetComponent<Animator>();

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.name == "ScreenBottom")
        {
            Debug.Log(collision.gameObject.name);
            destroyMe = true;
            
            animator.SetTrigger("destroy");

            counter = dynamischErzeugen.NumberBlocks;
            


            ChangeText.instance.counterText.text = counter.ToString();
            counter--;
            dynamischErzeugen.NumberBlocks = counter;
        }

    }

    // Update is called once per frame
    void Update () {
        if (destroyMe)
        {
            if (animator.GetCurrentAnimatorStateInfo(0).IsName("ExplosionBlock"))
            {
                Destroy(this.gameObject);
                Debug.Log("BOOOM");
            }
                
        }
    }
}
