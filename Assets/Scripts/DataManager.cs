using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.IO; // The System.IO namespace contains functions related to loading and saving files
using UnityEngine.UI;


public static class DataManager { 

    private static int playerIQ = 0;


    // Initiales Laden der relevanten Daten bei App Start
    //(bei Bedarf auf die gebräuchlichsten reduzieren und den Rest später extra laden)
   public static void InitialLoad()
    {
        
        if (PlayerPrefs.HasKey("PlayerIQ"))
        {
            playerIQ = PlayerPrefs.GetInt("PlayerIQ");

        }
    }

    // Speichern aller Daten 
    // (bei Bedarf auf beenden und save Button beschränken und bei runtime nur Sachen einzeln speichern)
    
    public static void SaveAllData()
    {
        PlayerPrefs.SetInt("PlayerIQ", playerIQ);
    }
    
    //Getter/Setter für die einzelnen Stats
    public static int PlayerIQ
    {
        get { return playerIQ; }
        set { playerIQ = value; SaveAllData();  }
    }
    
    //  

   

    
}