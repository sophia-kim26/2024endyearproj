using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using System.Threading.Tasks;

public class game : MonoBehaviour
{

    public GameObject leftArrow;
    public GameObject downArrow;
    public GameObject upArrow;
    public GameObject rightArrow;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(AddArrowsWithDelay());
    }

    IEnumerator AddArrowsWithDelay()
    {
        addLeft();
        yield return new WaitForSeconds(1f);
        addDown();
        yield return new WaitForSeconds(1f);
        addUp();
        yield return new WaitForSeconds(1f);
        addRight();
        yield return new WaitForSeconds(1f);
        addDown();
        yield return new WaitForSeconds(1f);
        addUp();
        yield return new WaitForSeconds(1f);
        addLeft();
        yield return new WaitForSeconds(1f);
        addDown();
        yield return new WaitForSeconds(1f);
    }

    void addLeft() {
        // TODO: figure out location
        GameObject newLeft = Instantiate(leftArrow, new Vector3(-3.04f, -6.15f, 0f), Quaternion.identity);
    }

    void addDown() {
        // TODO: figure out location
        GameObject newDown = Instantiate(downArrow, new Vector3(-0.88f, -6.15f, 0f), Quaternion.identity);
    }

    void addUp() {
        // TODO: figure out location
        GameObject newUp = Instantiate(upArrow, new Vector3(1.05f, -6.15f, 0f), Quaternion.identity);
    }

    void addRight() {
        // TODO: figure out location
        GameObject newRight = Instantiate(rightArrow, new Vector3(3.18f, -6.15f, 0), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
