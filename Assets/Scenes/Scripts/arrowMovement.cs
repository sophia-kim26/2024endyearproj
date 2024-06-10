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
    private ButtonAction buttonActionScript;

    // maybe we need to add SerializeField stuff here? idk what it actually does

    // Start is called before the first frame update
    void Start()
    {
        if (left == null || right == null || up == null || down == null)
        {
            Debug.LogError("Please assign all arrow GameObjects in the Inspector.");
        }

        // Debug.Log("test log in arrowMovement");
        paused = false;

        buttonActionScript = FindObjectOfType<ButtonAction>();
        // Instantiate(left, new Vector3(0, -1, 0), Quaternion.identity);
        
    }

    // Update is called once per frame
    void Update()
    {
        paused = buttonActionScript.paused;
        Debug.Log(paused);
        if (!paused)
        {
            if (left != null) left.transform.Translate(Vector3.up * speed * Time.deltaTime);
            if (right != null) right.transform.Translate(Vector3.up * speed * Time.deltaTime);
            if (up != null) up.transform.Translate(Vector3.up * speed * Time.deltaTime);
            if (down != null) down.transform.Translate(Vector3.up * speed * Time.deltaTime);
        }    
    }
}