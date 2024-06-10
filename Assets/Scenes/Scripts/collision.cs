using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision : MonoBehaviour
{

    private float score = 0f;
    private float health = 100f;


    // i don't really understand this so it won't work but 
    // i think the code could work something like this??
    void OnCollisionEnter(Collision collision) {
            if (Input.GetKeyDown(KeyCode.UpArrow) && collision.gameObject.name == "upArrow")
            {
                score++;
                Debug.Log("up arrow hit correctly");
            }
            else if (Input.GetKeyDown(KeyCode.DownArrow)) // and this object collided with a downArrow
            {
                score++;
            }
            else if (Input.GetKeyDown(KeyCode.RightArrow)) // and this object collided with a rightArrow
            {
                score++;
            }
            else if (Input.GetKeyDown(KeyCode.LeftArrow)) // and this object collided with a leftArrow
            {
                score++;
            }
            else {
                health--;
            }
    }
    
}