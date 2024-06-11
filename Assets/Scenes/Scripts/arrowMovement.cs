using UnityEngine;

public class arrowMovement : MonoBehaviour
{
    private float speed = 7.0f;
    private bool paused = false;

    // Update is called once per frame
    void Update()
    {
        if (!paused)
        {
            // Move the arrow
            transform.Translate(Vector3.up * speed * Time.deltaTime);
        }
    }

    public void SetPaused(bool isPaused)
    {
        paused = isPaused;
    }
}