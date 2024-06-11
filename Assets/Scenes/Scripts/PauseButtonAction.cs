using System.Collections;  
using System.Collections.Generic;  
using UnityEngine;  
  
public class PauseButtonAction : MonoBehaviour  
{  
    public bool paused { get; private set; }
    
    public void OnButtonPress(){  
        paused = !paused;
        Debug.Log("Paused: " + paused);
        if (paused == true) {
            AudioListener.pause = true;
        }
        else {
            AudioListener.pause = false;
        }

        arrowMovement[] arrows = FindObjectsOfType<arrowMovement>();

        foreach (arrowMovement arrow in arrows)
        {
            arrow.SetPaused(paused);
        }
    }  
}  