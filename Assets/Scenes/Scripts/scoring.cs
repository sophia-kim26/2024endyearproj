using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrowMovement : MonoBehaviour
{

    private float score = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            //weapon stuff here
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            //weapon stuff here
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            //weapon stuff here
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            //weapon stuff here
        }
    }
}
