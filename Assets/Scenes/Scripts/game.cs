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
    public bool gameOver = false;
    public List<GameObject> lefts = new List<GameObject>();
    public List<GameObject> downs = new List<GameObject>();
    public List<GameObject> ups = new List<GameObject>();
    public List<GameObject> rights = new List<GameObject>();
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

    void addLeft(float y) {
        // TODO: figure out location
        GameObject newLeft = Instantiate(leftArrow, new Vector3(-3.04f, y, 0f), Quaternion.identity);
        lefts.Add(newLeft);
        
        // MidiNote newLeftMidi = new MidiNote(0, 0, 0, 0, 1);
        // Conductor.Instance.leftMidiNotes.Add(newLeftMidi);
    }

    void addDown(float y) {
        // TODO: figure out location
        GameObject newDown = Instantiate(downArrow, new Vector3(-0.88f, y, 0f), Quaternion.identity);
        downs.Add(newDown);
        // MidiNote newDownMidi = new MidiNote(0, 0, 0, 0, 1);
        // Conductor.Instance.leftMidiNotes.Add(newDownMidi);
    }

    void addUp(float y) {
        // TODO: figure out location
        GameObject newUp = Instantiate(upArrow, new Vector3(1.05f, y, 0f), Quaternion.identity);
        ups.Add(newUp);
        // MidiNote newUpMidi = new MidiNote(0, 0, 0, 0, 1);
        // Conductor.Instance.leftMidiNotes.Add(newUpMidi);
    }

    void addRight(float y) {
        // TODO: figure out location
        GameObject newRight = Instantiate(rightArrow, new Vector3(3.18f, y, 0), Quaternion.identity);
        rights.Add(newRight);
        // MidiNote newRightMidi = new MidiNote(0, 0, 0, 0, 1);
        // Conductor.Instance.leftMidiNotes.Add(newRightMidi);
    }

    // Update is called once per frame
    void Update()
    {
        // if(gameOver == true){
        //     SceneManager.LoadScene("end");
        // }
    }
}
