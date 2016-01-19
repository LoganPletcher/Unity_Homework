﻿using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

    public Transform startMarker;
    public Transform endMarker;
    public float speed = 1.0F;
    private float startTime;
    private float journeyLength;

    // Use this for initialization
    void Start () {
        startTime = Time.time;
        journeyLength = Vector3.Distance(startMarker.position, endMarker.position);
    }
	
	// Update is called once per frame
	void Update () {
        //float translation = Time.deltaTime * 10;
        //if (Input.GetKeyDown(KeyCode.A))
        //{

        //}
        float distCovered = (Time.time - startTime) * speed;
        float fracJourney = distCovered / journeyLength;
        transform.position = Vector3.Lerp(startMarker.position, endMarker.position, fracJourney);
    }
}
