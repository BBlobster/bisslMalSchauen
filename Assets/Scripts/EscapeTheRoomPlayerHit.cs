using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Pathfinding
{
    /* !!! UNDER CONSTRUCTION !!!
     */
    public class EscapeTheRoomPlayerHit : MonoBehaviour
    {

        private GameObject gameManager;
        private GameController gameController;
        private AILerp pathend;
        // Use this for initialization
        void Start()
        {
            pathend = gameObject.GetComponent<AILerp>();
        }

        // Update is called once per frame
        void Update()
        {

        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            Debug.Log(collision.collider.name);

            if (pathend.reachedEndOfPath)
            {
                Debug.Log("weg beendet und steht am: "+ collision.collider.name);

            }
        }

        void gameOver(string collisionName, int punkte)
        {
            gameManager = GameObject.Find("GameManager");
            gameController = gameManager.GetComponent<GameController>();
            gameController.GameOver(punkte, "BlockGame");
        }
    }
}