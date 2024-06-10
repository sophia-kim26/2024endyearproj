using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class game : MonoBehaviour
{

    public GameObject leftArrow;
    public GameObject downArrow;
    public GameObject upArrow;
    public GameObject rightArrow;
    // Start is called before the first frame update
    void Start()
    {
        addLeft();
        

        
    }

    void addLeft() {
        // TODO: figure out location
        GameObject newLeft = Instantiate(leftArrow, new Vector3(779, 0, 0), Quaternion.identity);
    }

    void addDown() {
        // TODO: figure out location
        GameObject newDown = Instantiate(downArrow, new Vector3(779, 0, 0), Quaternion.identity);
    }

    void addUp() {
        // TODO: figure out location
        GameObject newUp = Instantiate(upArrow, new Vector3(779, 0, 0), Quaternion.identity);
    }

    void addRight() {
        // TODO: figure out location
        GameObject newRight = Instantiate(rightArrow, new Vector3(779, 0, 0), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
