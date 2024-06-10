using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrowMovement : MonoBehaviour
{

    private float speed = 3.0f;
    private bool paused = false;
    public GameObject left;
    public GameObject right;
    public GameObject up;
    public GameObject down;
    private ButtonAction buttonActionScript;

    // Start is called before the first frame update
    void Start()
    {
        buttonActionScript = FindObjectOfType<ButtonAction>();
        if (buttonActionScript == null) {
            Debug.LogError("ButtonAction script not found in the scene.");
        }


        if (left == null || right == null || up == null || down == null)
        {
            Debug.LogError("Please assign all arrow GameObjects in the Inspector.");
        }

        // Debug.Log("test log in arrowMovement");
        paused = false;

        // Instantiate(left, new Vector3(0, -1, 0), Quaternion.identity);
        
    }

    // Update is called once per frame
    void Update()
    {
        paused = buttonActionScript.paused;
        Debug.Log("Paused: " + paused);

        if (!paused)
        {
            if (left != null) left.transform.Translate(Vector3.up * speed * Time.deltaTime);
            if (right != null) right.transform.Translate(Vector3.up * speed * Time.deltaTime);
            if (up != null) up.transform.Translate(Vector3.up * speed * Time.deltaTime);
            if (down != null) down.transform.Translate(Vector3.up * speed * Time.deltaTime);
        }    
    }
}