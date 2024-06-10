using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrowMovement : MonoBehaviour
{

    private float speed = 1.0f;
    public leftArrow left;
    public rightArrow right;
    public upArrow up;
    public downArrow down;

    // maybe we need to add SerializeField stuff here? idk what it actually does

    // Start is called before the first frame update
    void Start()
    {
        // sorry i had to comment this out to get rid of the compile error
        // Instantiate(left, new Vector3(0, -1, 0), Quaternion.identity);
        Debug.Log("test log in arrowMovement");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up*speed*Time.deltaTime);
    }
}