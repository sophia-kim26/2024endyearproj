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
        addUp(3.36f-(3.36f-(-10.5f)/5f*7f));
        addRight(3.36f-(3.36f-(-11.6f)/5f*7f));
        addUp(3.36f-(3.36f-(-12.8f)/5f*7f));
        addRight(3.36f-(3.36f-(-13.9f)/5f*7f));

        // baDaDaDa
        addRight(3.36f-(3.36f-(-27.5f)/5f*7f));
        addLeft(3.36f-(3.36f-(-28f)/5f*7f));
        addRight(3.36f-(3.36f-(-28.5f)/5f*7f));
        addLeft(3.36f-(3.36f-(-29f)/5f*7f));

        // badadada
        // badadada!!
        addUp(3.36f-(3.36f-(-34.5f)/5f*7f));
        addLeft(3.36f-(3.36f-(-35f)/5f*7f));
        addUp(3.36f-(3.36f-(-35.5f)/5f*7f));
        addLeft(3.36f-(3.36f-(-36f)/5f*7f));

        // baDaDaDa
        addLeft(3.36f-(3.36f-(-41.5f)/5f*7f));
        addRight(3.36f-(3.36f-(-42f)/5f*7f));
        addLeft(3.36f-(3.36f-(-42.5f)/5f*7f));
        addRight(3.36f-(3.36f-(-43f)/5f*7f));

        // badadada
        // badadada!!
        addLeft(-64.5f);
        addUp(-65.2f);
        addLeft(-65.9f);
        addUp(-66.6f);

        // dadadodum
        addUp(-71.5f);
        addRight(-72.2f);
        addUp(-72.9f);
        addRight(-73.6f);

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
        addDown(-87.5f);
        addRight(-88.2f);

        // DA
        addLeft(-93.9f);

        // DUMMMM
        addRight(-98.5f);

        // badadadumm
        addLeft(-111.5f);
        addUp(-112.2f);
        addLeft(-112.9f);
        addUp(-113.6f);

        // theres a whole build up here that im too lazy to do

        // dA dA dA dA dUM
        addLeft(-211.5f);
        addRight(-212.2f);
        addLeft(-212.9f);
        addRight(-213.6f);
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
