using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharcaterOnOFF : MonoBehaviour {
    public bool ComingSoon;
    public static CharcaterOnOFF instance;
    // Use this for initialization
      public void Update() {
        instance = this;
      
    }

}
