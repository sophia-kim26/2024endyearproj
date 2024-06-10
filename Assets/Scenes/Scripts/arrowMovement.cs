using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrowMovement : MonoBehaviour
{

    private float speed = 1.0f;
    public GameObject left;
    public GameObject right;
    public GameObject up;
    public GameObject down;

    // maybe we need to add SerializeField stuff here? idk what it actually does

    // Start is called before the first frame update
    void Start()
    {
        // Instantiate(left, new Vector3(0, -1, 0), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up*speed*Time.deltaTime);
    }
}