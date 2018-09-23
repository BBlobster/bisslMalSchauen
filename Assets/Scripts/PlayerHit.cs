using UnityEngine;

public class PlayerHit : MonoBehaviour {

    private SceneSwitch sceneSwitch;
    private GameObject gameManager;
    private GameController gameController;
    // Use this for initialization
    void Start () {
        sceneSwitch = gameObject.AddComponent<SceneSwitch>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.name);
        if (collision.name == "PrefabBlock(Clone)")
        {
            gameOver(collision.name);

        }
                
    }

    private void OnGUI()
    {
    }

    void gameOver(string collisionName)
    {
        gameManager = GameObject.Find("GameManager");
        gameController = gameManager.GetComponent<GameController>();
        int p = -1;
        if (collisionName == "Goal"){ p = 1;}
        gameController.GameOver(p,"BlockGame") ;
    }
}
