using System.Collections;  
using System.Collections.Generic;  
using UnityEngine;  
using UnityEngine.SceneManagement;
  
public class backButtonAction : MonoBehaviour  
{  
    public bool backed { get; private set; }
    
    public void OnButtonPress(){  
        backed = !backed;
        SceneManager.LoadScene("start");
        Debug.Log("Back: " + backed);
    }  
}  