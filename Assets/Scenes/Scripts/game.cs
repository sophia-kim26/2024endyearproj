using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class game : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Thread.Sleep(1000);
        leftArrow l1 = new GameObject("NewGameObjectsName!");
        addObject(new leftArrow(), 779, );
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
