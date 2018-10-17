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
            pathend = gameObject.GetComponentInParent<AILerp>();
        }

        private void GameOver(string collisionName, int punkte)
        {
            gameManager = GameObject.Find("GameManager");
            gameController = gameManager.GetComponent<GameController>();
            gameController.GameOver(punkte, "EscapeTheRoom");
        }
    }
}