using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndDrop : MonoBehaviour {

    private Color mouseOverColor = Color.blue;
    private Color originalColor;
    private SpriteRenderer spriteRenderer;

    private bool dragging = false;
    private float distance;
	
    // Use this for initialization
	void Start () {
        spriteRenderer = GetComponent<SpriteRenderer>();
        originalColor = spriteRenderer.color;

    }

    void OnMouseExit(){
        spriteRenderer.color = originalColor;

    }

    void OnMouseEnter(){
        spriteRenderer.color = mouseOverColor;
    }

    void OnMouseDown(){
        distance = Vector3.Distance(transform.position, Camera.main.transform.position);
        dragging = true;
    }

    void OnMouseUp(){
        dragging = false;
    }

    // Update is called once per frame
    void Update () {
        if (dragging)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Vector3 rayPoint = ray.GetPoint(distance);
            transform.position = rayPoint;
        }
    }
}
       
   


   

    

    

   


