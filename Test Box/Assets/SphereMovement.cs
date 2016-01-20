using UnityEngine;
using System.Collections;

public class SphereMovement : MonoBehaviour {

	float LERP (float C, float T, float P, float S)
	{
		float lerp = C + P * (T - S);
		return lerp;
	}

	bool bounce = false;

	// Use this for initialization
	void Start ()
	{
		
	}

    public float speed;

	// Update is called once per frame
	void Update ()
	{
		float currentPos = transform.position.y;
		if(bounce == false)
		{
			transform.position = new Vector3 (0,LERP(currentPos,5,speed,0),5);
			//RAte += .5F;
			if(currentPos >= 5)
			{
				bounce = true;
			}
		}
		if (bounce == true)
		{
			transform.position = new Vector3 (0,LERP(currentPos,0,speed,5),5);
			//RAte -= .5F;
			if(currentPos <= 0)
			{
				bounce = false;
			}
		}
	}
}