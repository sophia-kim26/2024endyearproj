using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class downArrow : Arrow
{

    downArrow left;

    // Start is called before the first frame update
    void Start()
    {
        left = new arrow("l");
        print(left.get_name());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
