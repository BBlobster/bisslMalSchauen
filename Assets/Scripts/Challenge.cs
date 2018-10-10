using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Challenge {

    /* challengeID is a Server-unique id for each Challenge
     * playerOneID, PlayerTwoID are the unique Usernames/UserIDs
     * miniGame is a unique String for each minigame
     * playerIDWinner is filled with the playerID of the winner. this could be changed to two bools,
     * but this way you can easily send a Serverrequest "give me all Challenges where this UserID == WinnerID"...
     */

    private string challengeID,playerOneID, playerTwoID, miniGame, playerIDWinner;
    private int pointsPlayerOne, pointsPlayerTwo;
    /* enum for the possible states during the lifecycle of the Challenge
     * 0 - REQUEST - Starting state of each challenge, created by the contructor.
     * 1 - ACCEPTED - Second player accepted the request or matchmaking was successful. Start of the Minigames.
     * 2 - PLAYER_ONE_OPEN - Player two has finished the minigameset and the Points are saved, player one has not finished
     * 3 - PLAYER_TWO_OPEN - Player one has finished the minigameset and the Points are saved, player two has not finished
     * 4 - FINISHED - Both Players finished the minigames and there is a result.
     * 5 - CANCELLED - The Challenged was cancelled
     * 6 - NUMBER_OF_STATES - Count of possible states, used to initialize an array for the timestamps of statechanges
     */
    private enum States { REQUEST, ACCEPTED, PLAYER_ONE_OPEN, PLAYER_TWO_OPEN, FINISHED, CANCELLED, NUMBER_OF_STATES };
    private States state;
    /* Array for timestamps of statechanges
     * 
     * The Arrayposition of the timestamp represents the corresponding state from the enum States
     */
    private DateTime[] arrStatusSince;
    
    /* Constructer for Challenge 
     * Every Challenge starts as a request.
     * In case of a random match the request has just PlayerOneID, so PlayerTwoID is optional. 
     */
    public Challenge(string playerOneID, string playerTwoID)
    {
        this.playerOneID = playerOneID;
        if (playerTwoID != null) { this.playerTwoID = playerTwoID; }
            state = States.REQUEST;
            arrStatusSince = new DateTime[(int) States.NUMBER_OF_STATES];
            arrStatusSince.SetValue(DateTime.Now, (int)States.REQUEST);
            challengeID = "P1 {playerOneID} P2 {playerTwoID} Time{DateTime.Now.ToLongTimeString()}";

    }
    /* Sets state of the challenge accepted.
     * PlayerTWOID is optional in case of this was not a random match
     */
    public void SetAccepted(string playerTwoID, string miniGame )
    {
            if (playerTwoID != null)
            {
                this.playerTwoID = playerTwoID;
            }
            else if (this.playerTwoID == null)
            {
            Debug.Log("there is no second Player, but you are trying to set this Challenge ACCEPTED");
            }
            state = States.REQUEST;
            arrStatusSince.SetValue(DateTime.Now, (int)States.ACCEPTED);
    }

    /* Sets state of the challenge cancelled.
     */
    public void SetCancelled()
    {
            state = States.CANCELLED;
            arrStatusSince.SetValue(DateTime.Now, (int)States.CANCELLED);
    }


    /* Sets the given points for the given playerID
     * Determines whether there are already points and which state must be set.
     */
    public void SetPoints(string playerID, int points)
    {
        /*if functions is called for PlayerOne and the state ist PLAYER_ONE_OPEN call finished because all points aare set
         * if the function is accidantally called twice for one Player it just changes the timestamp of the statechange
         */
        if (playerOneID == playerID)
        {
                pointsPlayerOne = points;
            if (    state == States.PLAYER_ONE_OPEN)
            {
                SetFinished();
            }
            else
            {
                state = States.PLAYER_TWO_OPEN;
                arrStatusSince.SetValue(DateTime.Now, (int)States.PLAYER_TWO_OPEN);
            }
        }
        else
        {
                pointsPlayerTwo = points;
            if (    state == States.PLAYER_TWO_OPEN)
            {
                SetFinished();
            }
            else
            {
                    state = States.PLAYER_ONE_OPEN;
                    arrStatusSince.SetValue(DateTime.Now, (int)States.PLAYER_ONE_OPEN);
            }
        }
    }

    /* Sets the state to finished
     * Sets the String playerIDWinner in case of a tie the playerIDWinner remains null
     */

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

            state = States.FINISHED;
            arrStatusSince.SetValue(DateTime.Now, (int)States.FINISHED);
    }

}
