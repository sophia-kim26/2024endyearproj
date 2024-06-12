using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[SerializeField]
public Image oldImage;
[SerializeField]
public Sprite newImage;

public class ChangeLifeImage : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ImageChange() {
        oldImage.sprite = newImage;
    }
}
