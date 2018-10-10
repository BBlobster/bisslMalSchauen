using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* Drag an Drop Script for the Player.
 * Changes the color onMouseDown and shwos the dragging in the FixedUpdate method
 * 
 * !!!MUSS komplett umgeschrieben werden wenn wir entschieden haben wie wir mit Smartphone Inputs umgehen!!!
 */
public class DragAndDrop : MonoBehaviour {

    public Color mouseOverColor;
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

    void FixedUpdate () {
        if (dragging)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Vector3 rayPoint = ray.GetPoint(distance);
            transform.position = rayPoint;
        }
    }
}
       
   


   

    

    

   


