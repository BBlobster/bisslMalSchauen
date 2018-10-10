using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.IO; // The System.IO namespace contains functions related to loading and saving files
using UnityEngine.UI;

/* The Datamanager is a static Dataprovider for the Stats, Gamemanger.
 * It handles the loading and saving of data into the filesystem and Server.
 * As it is static it is an easy to use Dataprovider for the Stats and the Gamemanager but
 * it should not be used for heavy objects which needed temporaly only, 
 * because static referenced objects won't be destroyed by the GC.
 */

public static class DataManager { 

    private static int playerIQ = 0;


    /* Loads all relevant Data on Gamestart
     * Should trigger the Load and Synchronisation between Filesystem and Server.
    */
   public static void InitialLoad()
    {
        
        if (PlayerPrefs.HasKey("PlayerIQ"))
        {
            playerIQ = PlayerPrefs.GetInt("PlayerIQ");

        }
    }

    /* Trigger the Save of all Data
     * If there is a need to save specific data we could do it here or inside the savemanager
    */ 
    public static void SaveAllData()
    {
        PlayerPrefs.SetInt("PlayerIQ", playerIQ);
    }
    
    /*
     * Getter/Setter for Stats loade on InitialLoad
     */
    public static int PlayerIQ
    {
        get { return playerIQ; }
        set { playerIQ = value; SaveAllData();  }
    }
    
    

   

    
}