using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeText : MonoBehaviour {

        public static ChangeText instance;
        void Awake()
        {
            instance = this;
        }
        public Text iQAnzeige;
        public Text counterText;
        
    

}
