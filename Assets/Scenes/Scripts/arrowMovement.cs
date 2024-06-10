using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrowMovement : MonoBehaviour
{

    private float speed = 5.0f;
    private bool paused = false;
    public GameObject left;
    public GameObject right;
    public GameObject up;
    public GameObject down;
    private ButtonAction buttonActionScript;
    Vector3 direction = Vector3.up;

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

        direction = Vector3.up;
        if (paused) direction = Vector3.zero;

        if (left != null) left.transform.Translate(direction * speed * Time.deltaTime);
        if (right != null) right.transform.Translate(direction * speed * Time.deltaTime);
        if (up != null) up.transform.Translate(direction * speed * Time.deltaTime);
        if (down != null) down.transform.Translate(direction * speed * Time.deltaTime);  
    }
}