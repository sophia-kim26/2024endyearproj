using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scoring : MonoBehaviour
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
        // i don't really understand this so it won't work but 
        // i think the code could work something like this??
        void OnCollisionEnter(Collision collision) {
            // debug.log("got touched by" + collision);
            if (Input.GetKeyDown(KeyCode.UpArrow)) // and this object collided with an upArrow
            {
                score++;
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
            

            if(health <= 0){
                SceneManager.LoadScene("endScene");
            }
        }

    }
    
}