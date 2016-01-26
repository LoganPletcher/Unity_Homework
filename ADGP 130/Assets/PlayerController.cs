using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    bool pressW = false;
    bool pressS = false;
    bool pressA = false;
    bool pressD = false;

	// Use this for initialization
	void Start ()
    {

    }
	
	// Update is called once per frame
	void Update ()
    {
        Vector3 Previous = gameObject.transform.position;
        //gameObject += .5f;
        //gameObject.transform.position = new Vector3();
        //print(gameObject.transform.position);
        if (Input.GetKeyDown("w"))
            pressW = true;
        if (Input.GetKeyUp("w"))
            pressW = false;
        if (pressW == true)
            gameObject.transform.position = new Vector3
                (Previous.x, Previous.y, (Previous.z + .05f));
        Previous = gameObject.transform.position;
        if (Input.GetKeyDown("s"))
            pressS = true;
        if (Input.GetKeyUp("s"))
            pressS = false;
        if (pressS == true)
            gameObject.transform.position = new Vector3
                (Previous.x, Previous.y, (Previous.z - .05f));
        Previous = gameObject.transform.position;
        if (Input.GetKeyDown("a"))
            pressA = true;
        if (Input.GetKeyUp("a"))
            pressA = false;
        if (pressA == true)
            gameObject.transform.position = new Vector3
                ((Previous.x - .05f), Previous.y, Previous.z);
        Previous = gameObject.transform.position;
        if (Input.GetKeyDown("d"))
            pressD = true;
        if (Input.GetKeyUp("d"))
            pressD = false;
        if (pressD == true)
            gameObject.transform.position = new Vector3
                ((Previous.x + .05f), Previous.y, Previous.z);
        Previous = gameObject.transform.position;
        //print("W key was pressed");

        if (Input.GetKeyDown("space"))
            print("space key was pressed");
    }


}
