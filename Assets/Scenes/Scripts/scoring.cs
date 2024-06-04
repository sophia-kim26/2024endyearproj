using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrowMovement : MonoBehaviour
{

    private float score = 0f;
    private float health = 100f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        void OnCollisionEnter(Collision collision) {
            debug.log(got touched by” + collision )
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                score++;
            }
            else if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                score++;
            }
            else if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                score++;
            }
            else if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                score++;
            }
            else {
                health--;
            }
            
        }

    }
}