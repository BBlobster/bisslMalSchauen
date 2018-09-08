using UnityEngine;

public class PlayerHit : MonoBehaviour {

    private string message = "";

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.name != "Goal")
        {
            Debug.Log("Game over");
            message = "Game over";
            gameOver();
        }
        
    }

    private void OnGUI()
    {
    }

    void gameOver()
    {

    }
}
