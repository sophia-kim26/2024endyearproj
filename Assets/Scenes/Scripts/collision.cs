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
            else if (Input.GetKeyDown(KeyCode.DownArrow) && collision.gameObject.name == "downArrow") // and this object collided with a downArrow
            {
                score++;
                Debug.Log("down arrow hit correctly");
            }
            else if (Input.GetKeyDown(KeyCode.RightArrow) && collision.gameObject.name == "rightArrow") // and this object collided with a rightArrow
            {
                score++;
                Debug.Log("right arrow hit correctly");
            }
            else if (Input.GetKeyDown(KeyCode.LeftArrow) && collision.gameObject.name == "leftArrow") // and this object collided with a leftArrow
            {
                score++;
                Debug.Log("left arrow hit correctly");
            }
            else {
                health--;
            }
    }
    
}