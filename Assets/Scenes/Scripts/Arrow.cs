using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    private GameObject deathParticles;
    private ArrowType arrowType;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Death()
    {
        Instantiate(deathParticles, gameObject.transform.position, Quaternion.identity);
        Destroy(gameObject);
    }

    public ArrowType GetArrowType()
    {
        return arrowType;
    }
}
