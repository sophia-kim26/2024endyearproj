using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeLifeImage : MonoBehaviour
{
    // [SerializeField]
    public Image oldImage;
    // [SerializeField]
    public Sprite newImage;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ImageChange() {
        oldImage.sprite = newImage;
    }
}
