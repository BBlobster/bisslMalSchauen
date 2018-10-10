using UnityEngine;

/* Recognizes when Player is Hit by something and validates 
 */

public class PlayerHit : MonoBehaviour {

    private GameObject gameManager;
    private GameController gameController;

    /* Checks if the collision was relevant and then calls GameOver
     * GameOver uses GameObject.Find thats why it should not be called on every collision
     */
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.name);
        if (collision.name == "PrefabBlock(Clone)" || collision.name == "Goal")
        {
            GameOver(collision.name);
        }     
    }

    /* Determines the achieved points of the Player and calls the GameOver Function of the GameController
     * actually there are just to Options
     *      -1 Point if the player get hit by a block
     *      +1 Point if the player hits the goal
     */
    void GameOver(string collisionName)
    {
        gameManager = GameObject.Find("GameManager");
        gameController = gameManager.GetComponent<GameController>();
        int points = -1;
        if (collisionName == "Goal"){ points = 1;}
        gameController.GameOver(points,"BlockGame") ;
    }
}
