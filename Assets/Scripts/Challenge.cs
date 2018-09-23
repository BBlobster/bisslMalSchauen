using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Challenge {

    private string challengeID, playerOneID, playerTwoID, miniGame, playerIDWinner;
    private int pointsPlayerOne, pointsPlayerTwo;
    private DateTime[] arrStatusSince;
    private enum Status { REQUEST, ACCEPTED, PLAYER_ONE_OPEN, PLAYER_TWO_OPEN, FINISHED, CANCELLED, NUMBER_OF_STATUS };
    private Status status;


    /*Konstruktor für Request 
   (damit sollte aus aktueller Sicht jede Challenge starten) */
    public Challenge(string playerOneID, string playerTwoID)
    {
        this.playerOneID = playerOneID;
        if (playerTwoID != null) { this.playerTwoID = playerTwoID; }
        this.status = Status.REQUEST;
        this.arrStatusSince = new DateTime[(int) Status.NUMBER_OF_STATUS];
        this.arrStatusSince.SetValue(DateTime.Now, (int)Status.REQUEST);
        this.challengeID = "P1 {playerOneID} P2 {playerTwoID} Time{DateTime.Now.ToLongTimeString()}";

    }

    public void SetAccepted(string opponentID, string miniGame )
    {
        
    }
    public void SetCancelled()
    {
        this.status = Status.CANCELLED;
        this.arrStatusSince.SetValue(DateTime.Now, (int)Status.CANCELLED);
    }

    public void SetPoints(string playerID, int points)
    {
        
        if (this.playerOneID == playerID)
        {
            this.pointsPlayerOne = points;
            if (this.status == Status.PLAYER_ONE_OPEN)
            {
                SetFinished();
            }
            else
            {
                this.status = Status.PLAYER_TWO_OPEN;
                this.arrStatusSince.SetValue(DateTime.Now, (int)Status.PLAYER_TWO_OPEN);
            }
        }
        else
        {
            this.pointsPlayerTwo = points;
            if (this.status == Status.PLAYER_TWO_OPEN)
            {
                SetFinished();
            }
            else
            {
                this.status = Status.PLAYER_ONE_OPEN;
                this.arrStatusSince.SetValue(DateTime.Now, (int)Status.PLAYER_ONE_OPEN);
            }
        }
    }

    private void SetFinished()
    {
        if (pointsPlayerOne > pointsPlayerTwo)
        {
            playerIDWinner = playerOneID;
        }
        else if(pointsPlayerTwo > pointsPlayerOne)
        {
            playerIDWinner = playerTwoID;
        }
        else
        {
            playerIDWinner = null;
        }

        this.status = Status.FINISHED;
        this.arrStatusSince.SetValue(DateTime.Now, (int)Status.FINISHED);
    }
    

   
   

    
    


    /*Der Konstruktor enthält alle Daten, die beim Spielvereinbarung und nach Abschluss der eigenen Runde klar sein sollten
        es gibt 2 Varianten:
        1. Spiel vereinbart und der Opponent schließt zu erst ein Minigame ab
        2. Spiel vereinbart und der Player schließt zu erst ein Minigame ab
    */
  

}
