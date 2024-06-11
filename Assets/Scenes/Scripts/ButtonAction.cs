using System.Collections;  
using System.Collections.Generic;  
using UnityEngine;  
  
public class ButtonAction : MonoBehaviour  
{  
    public bool paused { get; private set; }
    
    public void OnButtonPress(){  
        paused = !paused;
        Debug.Log("Paused: " + paused);

        // Get all GameObjects with the arrowMovement script attached
        arrowMovement[] arrows = FindObjectsOfType<arrowMovement>();

        // Pause or unpause all arrows
        foreach (arrowMovement arrow in arrows)
        {
            arrow.SetPaused(paused);
        }
    }  
}  