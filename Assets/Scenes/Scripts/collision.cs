using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{

    // private SpriteRenderer sprite;
    // [SerializeField]
    // private ScreenFlash screenFlash;

    private float score = 0f;
    private float health = 100f;

    private bool isHitting;
    private bool killable;

    private ArrowType currentKillingType; // TODO

    void Start() {
        // sprite = GetComponent<SpriteRenderer>();
        isHitting = false;
    }

    void Update() {
        // keyPressed();
        if (Input.GetKeyDown(KeyCode.UpArrow)) {
            isHitting = true;
            StartCoroutine(Hitting());
            // TODO
            if (Conductor.Instance.CheckHit(NoteType.UpArrow) == true) {
                // screenFlash.Flash();
                killable = true;
                currentKillingType = ArrowType.UpArrow;
            }
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow)) {
            isHitting = true;
            StartCoroutine(Hitting());
            // TODO
            if (Conductor.Instance.CheckHit(NoteType.LeftArrow) == true) {
                // screenFlash.Flash();
                killable = true;
                currentKillingType = ArrowType.LeftArrow;
            }
        }
        if (Input.GetKeyDown(KeyCode.RightArrow)) {
            isHitting = true;
            StartCoroutine(Hitting());
            // TODO
            if (Conductor.Instance.CheckHit(NoteType.RightArrow) == true) {
                // screenFlash.Flash();
                killable = true;
                currentKillingType = ArrowType.RightArrow;
            }
        }
        if (Input.GetKeyDown(KeyCode.DownArrow)) {
            isHitting = true;
            StartCoroutine(Hitting());
            // TODO
            if (Conductor.Instance.CheckHit(NoteType.DownArrow) == true) {
                // screenFlash.Flash();
                killable = true;
                currentKillingType = ArrowType.DownArrow;
            }
        }
        else {
            isHitting = false;
            health -= 10;
        }
    }

    /// <summary>   
    /// Controls color of player on hit, and puts hitting on cooldown, so player can't spam.
    /// </summary>
    IEnumerator Hitting()
    {
        UpdateHitColor();
        yield return new WaitForSeconds(0.05f);
        isHitting = false;
        killable = false;
        // UpdateHitColor();
    }

    // not used
    public void UpdateHitColor()
    {
        if (isHitting)
            sprite.color = Color.blue;
        else
            sprite.color = Color.white;
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (killable)
        {
            if (currentKillingType == collision.GetComponent<Arrow>().GetNoteType())
                collision.GetComponent<Arrow>().Death();
        }
    }

    // void keyPressed() {
    //     if (Input.GetKeyDown(KeyCode.UpArrow)) {
    //         Debug.Log("Up arrow pressed");
    //     }
    //     else if (Input.GetKeyDown(KeyCode.DownArrow)) {
    //         Debug.Log("Down arrow pressed");
    //     }
    //     else if (Input.GetKeyDown(KeyCode.LeftArrow)) {
    //         Debug.Log("Left arrow pressed");
    //     }
    //     else if (Input.GetKeyDown(KeyCode.RightArrow)) {
    //         Debug.Log("Right arrow pressed");
    //     }
    // }

    // void OnCollisionEnter(Collision collision) {
    //         if (Input.GetKeyDown(KeyCode.UpArrow) && collision.gameObject.name == "upArrow")
    //         {
    //             score++;
    //             Debug.Log("up arrow hit correctly");
    //         }
    //         else if (Input.GetKeyDown(KeyCode.DownArrow) && collision.gameObject.name == "downArrow")
    //         {
    //             score++;
    //             Debug.Log("down arrow hit correctly");
    //         }
    //         else if (Input.GetKeyDown(KeyCode.RightArrow) && collision.gameObject.name == "rightArrow")
    //         {
    //             score++;
    //             Debug.Log("right arrow hit correctly");
    //         }
    //         else if (Input.GetKeyDown(KeyCode.LeftArrow) && collision.gameObject.name == "leftArrow")
    //         {
    //             score++;
    //             Debug.Log("left arrow hit correctly");
    //         }
    //         else {
    //             health--;
    //         }
    // }
    
}