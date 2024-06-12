using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine.SceneManagement;

public class game : MonoBehaviour
{

    public GameObject leftArrow;
    public GameObject downArrow;
    public GameObject upArrow;
    public GameObject rightArrow;
    public GameObject miss;
    public GameObject perfect;
    public GameObject good;
    public bool gameOver = false;
    public int health = 100;
    public int score = 0;
    public List<GameObject> lefts = new List<GameObject>();
    public List<string> leftHits = new List<string>();
    public List<GameObject> downs = new List<GameObject>();
    public List<string> downHits = new List<string>();
    public List<GameObject> ups = new List<GameObject>();
    public List<string> upHits = new List<string>();
    public List<GameObject> rights = new List<GameObject>();
    public List<string> rightHits = new List<string>();
    public ScreenFlash screenFlash;
    
    // Start is called before the first frame update    
    void Start()
    {
        Debug.Log("creating arrows");

        // also in theory if we wanted to increase speed we could they would all just look like scary equations like the ones in the beginning

        // BUM BUM BUM BUM
        addUp(3.36f-(3.36f-(-14.5f)/5f*7f)+2f);
        addRight(3.36f-(3.36f-(-15.2f)/5f*7f)+2f);
        addUp(3.36f-(3.36f-(-16f)/5f*7f)+2f);
        addRight(3.36f-(3.36f-(-16.8f)/5f*7f)+2f);

        // baDaDaDa
        addRight(3.36f-(3.36f-(-27.5f)/5f*7f)-3f);
        addLeft(3.36f-(3.36f-(-28f)/5f*7f)-3f);
        addRight(3.36f-(3.36f-(-28.5f)/5f*7f)-3f);
        addLeft(3.36f-(3.36f-(-29f)/5f*7f)-3f);

        // badadada
        // badadada!!
        addLeft(3.36f-(3.36f-(-34.5f)/5f*7f)-1f);
        addDown(3.36f-(3.36f-(-35f)/5f*7f)-1f);
        addUp(3.36f-(3.36f-(-35.5f)/5f*7f)-1f);
        addRight(3.36f-(3.36f-(-36f)/5f*7f)-1f);

        // baDaDaDa
        addLeft(3.36f-(3.36f-(-41.5f)/5f*7f)-1f);
        addRight(3.36f-(3.36f-(-42f)/5f*7f)-1f);
        addLeft(3.36f-(3.36f-(-42.5f)/5f*7f)-1f);
        addRight(3.36f-(3.36f-(-43f)/5f*7f)-1f);

        // badadada
        // badadada!!
        addLeft(-64.5f-1f);
        addDown(-65.2f-1f);
        addUp(-65.9f-1f);
        addRight(-66.6f-1f);

        // dadadodum
        addUp(-71.5f-1f);
        addRight(-72.2f-1f);
        addUp(-72.9f-1f);
        addRight(-73.6f-1f);

        // TOOD: tune
        // adadadodumm
        addLeft(-78.5f);
        addUp(-79.2f);
        addLeft(-79.9f);
        addUp(-80.6f);
        addLeft(-81.3f);

        // adadadodummm
        addRight(-85.4f);
        addDown(-86.1f);
        addRight(-86.8f);
        addDown(-87.5f );
        addRight(-88.2f );

        // DA
        addLeft(-95.9f );

        // DUMMMM
        addRight(-100.5f );

        // badadadumm
        addLeft(-111.5f-4f);
        addUp(-112.2f-4f);
        addLeft(-112.9f-4f);
        addUp(-113.6f-4f);

        addDown(-125f-15f);
        addDown(-126f-15f);
        addDown(-127f-15f);
        addRight(-128f-15f);

        addUp(-140f-15f);
        addUp(-141f-15f);
        addUp(-142f-15f);
        addLeft(-143f-15f);

        addDown(-157f-15f);
        addDown(-158f-15f);
        addDown(-159f-15f);
        addUp(-161f-15f);
        addRight(-162f-15f);

        addUp(-180f);
        addUp(-181f);
        addUp(-182f);
        addDown(-183f);
        addLeft(-184f);

        addUp(-190f);
        addRight(-190f);

        addLeft(-194.5f);
        addDown(-194.5f);

        addLeft(-199f);
        addRight(-199f);

        addUp(-203.5f);
        addDown(-203.5f);

        // addUp(-200.8f);
        // addRight(-200.8f);

        // addLeft(-203.5f);
        // addDown(-203.5f);

        addLeft(-208f);
        addRight(-208f);

        addUp(-212.5f);
        addDown(-212.5f);


        // addLeft(-202.4f);
        // addRight(-203.4f);
        // addLeft(-204.4f);
        // addRight(-205.4f);
        // addLeft(-206.4f);

        addLeft(-214f-2f);
        addDown(-215f-2f);

        addRight(-218-2f);
        addUp(-219f-2f);

        addLeft(-222f-2f);
        addDown(-223f-2f);

        addRight(-226f-2f);
        addUp(-227f-2f);


        addLeft(-234);
        addDown(-235.5f);
        addUp(-237f);
        addRight(-238.5f);

        addLeft(-241);
        addDown(-242.5f);
        addUp(-244f);
        addRight(-245.5f);


        addLeft(-251f);
        addDown(-252f);

        addRight(-254f);
        addUp(-255f);

        addLeft(-257f);
        addDown(-258f);

        addRight(-260f);
        addUp(-261f);
 
        addUp(-265f);

        addLeft(-274);
        addDown(-274f);
        addUp(-274f);
        addRight(-274f);

        Debug.Log("# of left arrows:" + lefts.Count);

        // SceneManager.LoadScene("end");
    }

    void perfect() {
        changeHealth(5);
        changeScore(20);
        Debug.Log("Perfect");
    }

    void good() {
        changeScore(10);
        Debug.Log("Good");
    }

    void miss() {
        changeHealth(10);
        Debug.Log("Missed");
    }

    void changeHealth(int points) {
        if (100 - health < points) {
            health = 100;
        }
        if (health < points) {
            health = 0;
        }
        else {
            health += points;
        }
    }

    void changeScore(int points) {
        if (100 - score < points) {
            score = 100;
        }
        else {
            score += points;
        }
    }

    void addLeft(float y) {
        GameObject newLeft = Instantiate(leftArrow, new Vector3(-3.04f, y, 0f), Quaternion.identity);
        lefts.Add(newLeft);
    }

    void addDown(float y) {
        GameObject newDown = Instantiate(downArrow, new Vector3(-0.88f, y, 0f), Quaternion.identity);
        downs.Add(newDown);
    }

    void addUp(float y) {
        GameObject newUp = Instantiate(upArrow, new Vector3(1.05f, y, 0f), Quaternion.identity);
        ups.Add(newUp);
    }

    void addRight(float y) {
        GameObject newRight = Instantiate(rightArrow, new Vector3(3.18f, y, 0), Quaternion.identity);
        rights.Add(newRight);
    }

    void addMiss() {
        GameObject newMiss = Instantiate(miss, new Vector3(10.0f, 20.0f, 0), Quaternion.identity);
    }
    void addPerfect() {
        GameObject newPerfect = Instantiate(perfect, new Vector3(10.0f, 20.0f, 0), Quaternion.identity);
    }
    void addGood() {
        GameObject newGood = Instantiate(good, new Vector3(10.0f, 20.0f, 0), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0){
            gameOver = true;
        }
        if (gameOver == true){
            SceneManager.LoadScene("end");
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow)) {
            Debug.Log("left arrow pressed");
            
            GameObject targetArrow = null;
            int  targetArrowIndex = -1;
            for (int i = 0; i < lefts.Count; i++) {

                if (lefts[i] != null) {
                    float arrowY = lefts[i].transform.position.y;
                    // if the arrow is in the valid hit area
                    if (arrowY > 2.8f && arrowY < 5.0f) { 
                        // if there's no current target arrow to compare it to make it the target arrow
                        if (targetArrow == null) {
                            targetArrow = lefts[i];
                             targetArrowIndex = i;
                        }
                        else {
                            // if this arrow is closer than target arrow make this target arrow
                            if (Mathf.Abs(arrowY-3.36f) < Mathf.Abs(targetArrow.transform.position.y - 3.36f)) {
                                targetArrow = lefts[i];
                                targetArrowIndex = i;
                            }
                        }
                    }
                }
            }
            // so now we have our lil target arrow

            if (targetArrow != null) {
                // if they missed any arrows
                if (leftHits.Count+1 <  targetArrowIndex) {
                    for (int i = leftHits.Count+1; i <  targetArrowIndex; i++) {
                        leftHits.Add("missed");
                        miss();
                        //addMiss();
                    }
                }

                float targetArrowY = targetArrow.transform.position.y;

                // perfect!
                if (Mathf.Abs(targetArrowY-3.36f) < 0.40f) {
                    // screenFlash.Flash();
                    leftHits.Add("perfect");
                    Destroy(targetArrow);
                    // screenFlash.Flash();
                    perfect();
                    //addPerfect();
                }

                // good!
                else if (Mathf.Abs(targetArrowY-3.36f) <  0.80f) {
                    // screenFlash.Flash();
                    leftHits.Add("good");
                    Destroy(targetArrow);
                    screenFlash.Flash();
                    good();
                    // screenFlash.Flash();
                    //addGood();
                }

                lefts[targetArrowIndex] = null;
            }

            // if (Conductor.Instance.CheckHit(ArrowType.UPARROW) == true) {
            //     Debug.Log("up arrow hit!!");
            //     screenFlash.Flash();

            //     score += 10;
            // }
        }

        if (Input.GetKeyDown(KeyCode.DownArrow)) {
            Debug.Log("down arrow pressed");
            
            GameObject targetArrow = null;
            int  targetArrowIndex = -1;
            for (int i = 0; i < downs.Count; i++) {

                if (downs[i] != null) {
                    float arrowY = downs[i].transform.position.y;
                    // if the arrow is in the valid hit area
                    if (arrowY > 2.8f && arrowY < 5.0f) { 
                        // if there's no current target arrow to compare it to make it the target arrow
                        if (targetArrow == null) {
                            targetArrow = downs[i];
                            targetArrowIndex = i;
                        }
                        else {
                            // if this arrow is closer than target arrow make this target arrow
                            if (Mathf.Abs(arrowY-3.36f) < Mathf.Abs(targetArrow.transform.position.y - 3.36f)) {
                                targetArrow = downs[i];
                                 targetArrowIndex = i;
                            }
                        }
                    }
                }
            }
            // so now we have our lil target arrow

            if (targetArrow != null) {
                // if they missed any arrows
                if (downHits.Count+1 <  targetArrowIndex) {
                    for (int i = downHits.Count+1; i <  targetArrowIndex; i++) {
                        downHits.Add("missed");
                        miss();
                        //addMiss();
                    }
                }

                float targetArrowY = targetArrow.transform.position.y;

                // perfect!
                if (Mathf.Abs(targetArrowY-3.36f) < 0.40f) {
                    downHits.Add("perfect");
                    Destroy(targetArrow);
                    // screenFlash.Flash();
                    perfect();
                    //addPerfect();
                }

                // good!
                else if (Mathf.Abs(targetArrowY-3.36f) <  0.80f) {
                    downHits.Add("good");
                    Destroy(targetArrow);
                    screenFlash.Flash();
                    good();
                    // screenFlash.Flash();
                    //addGood();
                }

                downs[targetArrowIndex] = null;
            }

            // if (Conductor.Instance.CheckHit(ArrowType.UPARROW) == true) {
            //     Debug.Log("up arrow hit!!");
            //     screenFlash.Flash();

            //     score += 10;
            // }
        }

        if (Input.GetKeyDown(KeyCode.UpArrow)) {
            Debug.Log("up arrow pressed");
            
            GameObject targetArrow = null;
            int  targetArrowIndex = -1;
            for (int i = 0; i < ups.Count; i++) {

                if (ups[i] != null) {
                    float arrowY = ups[i].transform.position.y;
                    // if the arrow is in the valid hit area
                    if (arrowY > 2.8f && arrowY < 5.0f) { 
                        // if there's no current target arrow to compare it to make it the target arrow
                        if (targetArrow == null) {
                            targetArrow = ups[i];
                             targetArrowIndex = i;
                        }
                        else {
                            // if this arrow is closer than target arrow make this target arrow
                            if (Mathf.Abs(arrowY-3.36f) < Mathf.Abs(targetArrow.transform.position.y - 3.36f)) {
                                targetArrow = ups[i];
                                 targetArrowIndex = i;
                            }
                        }
                    }
                }
            }
            // so now we have our lil target arrow

            if (targetArrow != null) {
                // if they missed any arrows
                if (upHits.Count+1 <  targetArrowIndex) {
                    for (int i = upHits.Count+1; i <  targetArrowIndex; i++) {
                        upHits.Add("missed");
                        miss();
                        //addMiss();
                    }
                }

                float targetArrowY = targetArrow.transform.position.y;

                // perfect!
                if (Mathf.Abs(targetArrowY-3.36f) < 0.40f) {
                    upHits.Add("perfect");
                    Destroy(targetArrow);
                    // screenFlash.Flash();
                    perfect();
                    //addPerfect();
                }

                // good!
                else if (Mathf.Abs(targetArrowY-3.36f) <  0.80f) {
                    upHits.Add("good");
                    Destroy(targetArrow);
                    screenFlash.Flash();
                    good();
                    // screenFlash.Flash();
                    //addGood();
                }

                ups[targetArrowIndex] = null;
            }

            // if (Conductor.Instance.CheckHit(ArrowType.UPARROW) == true) {
            //     Debug.Log("up arrow hit!!");
            //     screenFlash.Flash();

            //     score += 10;
            // }
        }

        if (Input.GetKeyDown(KeyCode.RightArrow)) {
            Debug.Log("right arrow pressed");
            
            GameObject targetArrow = null;
            int  targetArrowIndex = -1;
            for (int i = 0; i < rights.Count; i++) {

                if (rights[i] != null) {
                    float arrowY = rights[i].transform.position.y;
                    // if the arrow is in the valid hit area
                    if (arrowY > 2.8f && arrowY < 5.0f) { 
                        // if there's no current target arrow to compare it to make it the target arrow
                        if (targetArrow == null) {
                            targetArrow = rights[i];
                             targetArrowIndex = i;
                        }
                        else {
                            // if this arrow is closer than target arrow make this target arrow
                            if (Mathf.Abs(arrowY-3.36f) < Mathf.Abs(targetArrow.transform.position.y - 3.36f)) {
                                targetArrow = rights[i];
                                 targetArrowIndex = i;
                            }
                        }
                    }
                }
            }
            // so now we have our lil target arrow

            if (targetArrow != null) {
                // if they missed any arrows
                if (rightHits.Count+1 <  targetArrowIndex) {
                    for (int i = rightHits.Count+1; i <  targetArrowIndex; i++) {
                        rightHits.Add("missed");
                        miss();
                        //addMiss();
                    }
                }

                float targetArrowY = targetArrow.transform.position.y;

                // perfect!
                if (Mathf.Abs(targetArrowY-3.36f) < 0.40f) {
                    rightHits.Add("perfect");
                    Destroy(targetArrow);
                    // screenFlash.Flash();
                    perfect();
                    //addPerfect();
                }

                // good!
                else if (Mathf.Abs(targetArrowY-3.36f) <  0.80f) {
                    rightHits.Add("good");
                    Destroy(targetArrow);
                    screenFlash.Flash();
                    good();
                    // screenFlash.Flash();
                    //addGood();
                }

                rights[targetArrowIndex] = null;
            }

            // if (Conductor.Instance.CheckHit(ArrowType.UPARROW) == true) {
            //     Debug.Log("up arrow hit!!");
            //     screenFlash.Flash();

            //     score += 10;
            // }
        }

    }  
}
