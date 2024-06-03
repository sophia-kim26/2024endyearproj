using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrowMovement : MonoBehaviour
{

    private Vector3 dir = Vector3.up;
    private float speed = 1.0f;

    // maybe we need to add SerializeField stuff here? idk what it actually does

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(dir*speed*Time.deltaTime);
    }
}
