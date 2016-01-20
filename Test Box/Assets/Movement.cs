using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

	float r = .5F;
	bool bounce = false;

    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {
		float currentPos = transform.position.x;
        float translation = Time.deltaTime * 10;
		float rate = r / (5 - currentPos);
		float rate2 = r / (-5 - currentPos);
        //if (Input.GetKeyDown(KeyCode.D))
        //{
		if (bounce == false)
		{
			transform.position = new Vector3 (((5 - currentPos) * rate), 0, 0);
			r += .5F;
			if (currentPos >= 5)
			{
				bounce = true;
			}
		}
		if (bounce == true)
		{
			transform.position = new Vector3 (((-5 - currentPos) * rate2), 0, 0);
			r -= .5F;
			if (currentPos <= -5)
			{
				bounce = false;
			}
		}
        //}
		//transform.position = new Vector3 (((50 - currentPos)*.2F), 0, 0);
    }
}
