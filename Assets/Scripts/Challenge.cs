using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Challenge {

    private string gameID, opponentID, playerID, miniGame;
    private int pointsPlayer, pointsOpponent;
    private DateTime timeStamp;
    private bool won;

    public Challenge(string playerID, string opponentID)
    {
        this.playerID = playerID;
        
    }

    //Konstruktor für Request 
    //(damit sollte aus aktueller Sicht jede Challenge starten)


    private enum Status { REQUEST, ACCEPTED, PLAYER_OPEN, OPPONENT_OPEN, FINISHED, CANCELLED };

   
   

    
    


    /*Der Konstruktor enthält alle Daten, die beim Spielvereinbarung und nach Abschluss der eigenen Runde klar sein sollten
        es gibt 2 Varianten:
        1. Spiel vereinbart und der Opponent schließt zu erst ein Minigame ab
        2. Spiel vereinbart und der Player schließt zu erst ein Minigame ab
    */
  

}
