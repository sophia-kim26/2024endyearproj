using System.Collections;  
using System.Collections.Generic;  
using UnityEngine;  
using UnityEngine.UI;  

public class StartCamera : MonoBehaviour  
{  
    void Start() {
        GameObject.Find("StartButton").GetComponentInChildren<Text>().text = "start";
    }
}  