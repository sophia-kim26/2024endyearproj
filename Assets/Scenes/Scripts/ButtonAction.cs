using System.Collections;  
using System.Collections.Generic;  
using UnityEngine;  
  
public class ButtonAction : MonoBehaviour  
{  
    public bool paused { get; private set; }
    
    public void OnButtonPress(){  
        paused = !paused;
        //Debug.Log(paused);
    }  
}  