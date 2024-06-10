using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision : MonoBehaviour
{

    private float score = 0f;
    private float health = 100f;

    void Start() {

    }

    void Update() {
        keyPressed();
    }

    void keyPressed() {
        if (Input.GetKeyDown(KeyCode.UpArrow)) {
            Debug.Log("Up arrow pressed");
        }
        else if (Input.GetKeyDown(KeyCode.downArrow)) {
            Debug.Log("Down arrow pressed");
        }
        else if (Input.GetKeyDown(KeyCode.leftArrow)) {
            Debug.Log("Left arrow pressed");
        }
        else if (Input.GetKeyDown(KeyCode.rightArrow)) {
            Debug.Log("Right arrow pressed");
        }
    }

    void OnCollisionEnter(Collision collision) {
            if (Input.GetKeyDown(KeyCode.UpArrow) && collision.gameObject.name == "upArrow")
            {
                score++;
                Debug.Log("up arrow hit correctly");
            }
            else if (Input.GetKeyDown(KeyCode.DownArrow) && collision.gameObject.name == "downArrow")
            {
                score++;
                Debug.Log("down arrow hit correctly");
            }
            else if (Input.GetKeyDown(KeyCode.RightArrow) && collision.gameObject.name == "rightArrow")
            {
                score++;
                Debug.Log("right arrow hit correctly");
            }
            else if (Input.GetKeyDown(KeyCode.LeftArrow) && collision.gameObject.name == "leftArrow")
            {
                score++;
                Debug.Log("left arrow hit correctly");
            }
            else {
                health--;
            }
    }
    
}