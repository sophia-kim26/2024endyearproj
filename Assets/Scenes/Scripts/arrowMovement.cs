using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrowMovement : MonoBehaviour
{

    private float speed = 2.0f;
    private bool paused = false;
    public GameObject left;
    public GameObject right;
    public GameObject up;
    public GameObject down;

    // maybe we need to add SerializeField stuff here? idk what it actually does

    // Start is called before the first frame update
    void Start()
    {
        // sorry i had to comment this out to get rid of the compile error
        // Instantiate(left, new Vector3(0, -1, 0), Quaternion.identity);
        Debug.Log("test log in arrowMovement");
        paused = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(paused);
        // paused = gameObject.GetComponent<ButtonAction>().paused;
        if (paused == false) {
            
        }   
        left.transform.Translate(Vector3.up*speed*Time.deltaTime);    
        down.transform.Translate(Vector3.up*speed*Time.deltaTime);    
        up.transform.Translate(Vector3.up*speed*Time.deltaTime);    
        right.transform.Translate(Vector3.up*speed*Time.deltaTime);     
    }

    void Pause() {
        if (paused == false) paused = true;
        if (paused == true) paused = false;
    }
}