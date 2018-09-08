using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit : MonoBehaviour {

    private int thrust;
    public Rigidbody2D rb;
    public Animation animExplosion;
	// Use this for initialization
	void Start () {
        rb = GetComponent(typeof(Rigidbody2D)) as Rigidbody2D;
        animExplosion = GetComponent<Animation>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.name == "ButtonLeft" || collision.gameObject.name == "ButtonRight")
        {
            Debug.Log(collision.gameObject.name);
            animExplosion.Play ("BlockExplosion");
            Destroy(this.gameObject);
        }

    }

    // Update is called once per frame
    void Update () {
        thrust = -5;
        rb.AddForce(transform.up * thrust);
    }
}
