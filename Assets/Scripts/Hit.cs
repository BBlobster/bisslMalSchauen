using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit : MonoBehaviour {

    private BlockGenerator blockGenerator;
    private Animation explodeBlock;
    private Animator animator;
        


    // Use this for initialization
    void Start () {
        animator = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        /* Starts destroy animation which has an fix exit time, queued wrecked animation, stops the block
         * if the blocks hit the screenbottom
         */
        if (collision.gameObject.name == "ScreenBottom")
        {       
            animator.SetTrigger("destroy");
            animator.SetTrigger("wrecked");
            gameObject.GetComponent<Rigidbody2D>().velocity = Vector3.zero;
        }
    }
}
