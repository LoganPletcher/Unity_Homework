using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    public float speed = .05f;

    bool pressW = false;
    bool pressS = false;
    bool pressA = false;
    bool pressD = false;
    bool Jump = false;
    public float AirTime;

    public float Rspeed;

    public float angleBetween = 0.0F;
    public Transform target;

    // Use this for initialization
    void Start ()
    {
    }
	
	// Update is called once per frame
	void Update ()
    {
        Vector3 Previous = gameObject.transform.position;
        //Vector3 targetDir = target.position - transform.position;
        //angleBetween = Vector3.Angle(transform.forward, targetDir);

        //Quaternion PrevRotat = gameObject.transform.rotation;
        //gameObject += .5f;
        //gameObject.transform.position = new Vector3();
        //print(gameObject.transform.position);

        //Check out and use GetAxisRaw yo

        if (Input.GetKeyDown("w"))
            pressW = true;
        if (Input.GetKeyUp("w"))
            pressW = false;
        if (pressW == true)
            gameObject.transform.position = new Vector3
                (Previous.x, Previous.y, (Previous.z + (speed * Time.deltaTime)));
        Previous = gameObject.transform.position;
        if (Input.GetKeyDown("s"))
            pressS = true;
        if (Input.GetKeyUp("s"))
            pressS = false;
        if (pressS == true)
            gameObject.transform.position = new Vector3
                (Previous.x, Previous.y, (Previous.z - (speed * Time.deltaTime)));
        Previous = gameObject.transform.position;
        if (Input.GetKeyDown("a"))
            pressA = true;
        if (Input.GetKeyUp("a"))
            pressA = false;
        if (pressA == true)
            gameObject.transform.position = new Vector3
                ((Previous.x - (speed * Time.deltaTime)), Previous.y, Previous.z);
        Previous = gameObject.transform.position;
        if (Input.GetKeyDown("d"))
            pressD = true;
        if (Input.GetKeyUp("d"))
            pressD = false;
        if (pressD == true)
            gameObject.transform.position = new Vector3
                ((Previous.x + (speed * Time.deltaTime)), Previous.y, Previous.z);
        Previous = gameObject.transform.position;
        //print("W key was pressed");

        if (Input.GetKeyDown("space"))
            Jump = true;
        if (Jump == true)
        {
            AirTime += .05f;
            gameObject.transform.position = new Vector3
                (Previous.x, (Previous.y + (speed * Time.deltaTime)), Previous.z);
        }
        if (AirTime >= 1.0f)
        {
            Jump = false;
            AirTime = 0.0f;
        }

        float Rx = 0;
        float Ry = 0;

        Rx = Rspeed * 0.25f * Input.GetAxis("Mouse Y") * Time.deltaTime;
        Ry = Rspeed * 0.25f * Input.GetAxis("Mouse X") * Time.deltaTime;

        transform.Rotate(0, Ry, 0);

        //if (Input.mousePosition.x <= 829)
        //    gameObject.transform.rotation = new Quaternion
        //        (0, (PrevRotat.y - .005f), 0, PrevRotat.w);
        //PrevRotat = gameObject.transform.rotation;
        //if (Input.mousePosition.x >= 1090)
        //    gameObject.transform.rotation = new Quaternion
        //        (0, (PrevRotat.y + .005f), 0, PrevRotat.w);
        //PrevRotat = gameObject.transform.rotation;
        //print(Input.mousePosition.x);
        //print(gameObject.transform.rotation.y);
    }
    /*
            Rx = speed * 0.25f * Input.GetAxis("Mouse Y") * Time.deltaTime; 
            // Sets Rx to the difference the verticle movement of the mouse
            Ry = speed * 0.25f * Input.GetAxis("Mouse X") * Time.deltaTime;
    */

}
