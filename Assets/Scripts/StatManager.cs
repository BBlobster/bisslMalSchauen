using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.IO; // The System.IO namespace contains functions related to loading and saving files
using UnityEngine.UI;


public static class StatManager { 

    private static int playerIQ;
    private static 
    
    //getter setter für die einzelnen Stats
    public static int PlayerIQ
    {
        get { return playerIQ; }
        set { playerIQ = value;  }
    }
    
    //  

   private static void LoadPlayerStats()
    {
        // If PlayerPrefs contains a key called "highestScore", set the value of playerProgress.highestScore using the value associated with that key
        playerIQ = 0;
        if (PlayerPrefs.HasKey("PlayerIQ"))
        {
            playerIQ = PlayerPrefs.GetInt("PlayerIQ");
            
        }
    }

    // This function could be extended easily to handle any additional data we wanted to store in our PlayerProgress object
    private void SavePlayerProgress()
    {
        // Save the value playerProgress.highestScore to PlayerPrefs, with a key of "highestScore"
        PlayerPrefs.SetInt("PlayerIQ", playerIQ);
    }
}