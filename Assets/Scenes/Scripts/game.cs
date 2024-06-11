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

        // also in theory if we wanted to increase speed we could they would all just look like scary equations like the ones in the beginning

        // BUM BUM BUM BUM
        addUp(3.36f-(3.36f-(-7.5f)/5f*7f));
        addRight(3.36f-(3.36f-(-8.5f)/5f*7f));
        addUp(3.36f-(3.36f-(-8.5f)/5f*7f));
        addRight(3.36f-(3.36f-(-9.5f)/5f*7f));

        // baDaDaDa
        addRight(3.36f-(3.36f-(-27.5f)/5f*7f)+8f);
        addLeft(3.36f-(3.36f-(-28f)/5f*7f)+8f);
        addRight(3.36f-(3.36f-(-28.5f)/5f*7f)+8f);
        addLeft(3.36f-(3.36f-(-29f)/5f*7f)+8f);

        // badadada
        // badadada!!
        addUp(3.36f-(3.36f-(-34.5f)/5f*7f)+8f);
        addLeft(3.36f-(3.36f-(-35f)/5f*7f)+8f);
        addUp(3.36f-(3.36f-(-35.5f)/5f*7f)+8f);
        addLeft(3.36f-(3.36f-(-36f)/5f*7f)+8f);

        // baDaDaDa
        addLeft(3.36f-(3.36f-(-41.5f)/5f*7f)+8f);
        addRight(3.36f-(3.36f-(-42f)/5f*7f)+8f);
        addLeft(3.36f-(3.36f-(-42.5f)/5f*7f)+8f);
        addRight(3.36f-(3.36f-(-43f)/5f*7f)+8f);

        // badadada
        // badadada!!
        addLeft(-64.5f+8f);
        addUp(-65.2f+8f);
        addLeft(-65.9f+8f);
        addUp(-66.6f+8f);

        // dadadodum
        addUp(-71.5f+8f);
        addRight(-72.2f+8f);
        addUp(-72.9f+8f);
        addRight(-73.6f+8f);

        // adadadodumm
        addLeft(-78.5f+8f);
        addUp(-79.2f+8f);
        addLeft(-79.9f+8f);
        addUp(-80.6f+8f);
        addLeft(-81.3f+8f);

        // adadadodummm
        addRight(-85.4f+8f);
        addDown(-86.1f+8f);
        addRight(-86.8f+8f);
        addDown(-87.5f+8f);
        addRight(-88.2f+8f);

        // DA
        addLeft(-93.9f+8f);

        // DUMMMM
        addRight(-98.5f+8f);

        // badadadumm
        addLeft(-111.5f+8f);
        addUp(-112.2f+8f);
        addLeft(-112.9f+8f);
        addUp(-113.6f+8f);

        // theres a whole build up here that im too lazy to do

        // dA dA dA dA dUM
        addLeft(-211.5f+8f);
        addRight(-212.2f+8f);
        addLeft(-212.9f+8f);
        addRight(-213.6f+8f);
    }

    void addLeft(float y) {
        // TODO: figure out location
        GameObject newLeft = Instantiate(leftArrow, new Vector3(-3.04f, y, 0f), Quaternion.identity);
    }

    void addDown(float y) {
        // TODO: figure out location
        GameObject newDown = Instantiate(downArrow, new Vector3(-0.88f, y, 0f), Quaternion.identity);
    }

    void addUp(float y) {
        // TODO: figure out location
        GameObject newUp = Instantiate(upArrow, new Vector3(1.05f, y, 0f), Quaternion.identity);
    }

    void addRight(float y) {
        // TODO: figure out location
        GameObject newRight = Instantiate(rightArrow, new Vector3(3.18f, y, 0), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
