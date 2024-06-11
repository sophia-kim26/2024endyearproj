using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    [SerializeField]
    private GameObject deathParticles;
    private ArrowType arrowType;
    private SpriteRenderer spriteRenderer;



    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            // Assuming this is the condition to make this arrow disappear
            spriteRenderer.enabled = false;
        }
    }

    public void Death()
    {
        Instantiate(deathParticles, gameObject.transform.position, Quaternion.identity);
        Destroy(gameObject);
    }

    public float getY() {
        return transform.position.y;
    }

    public ArrowType GetArrowType()
    {
        return arrowType;
    }
}
