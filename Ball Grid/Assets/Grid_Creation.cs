using UnityEngine;
using System.Collections;

public class Grid_Creation : MonoBehaviour {
	public int n;

	// Use this for initialization
	void Start () {
		float X = -1-((.5F*n)*2);
		float Y = -1-((.5F*n)*2);
		for (int i = 2; i <= n*2; i+=2)
		{
			for (int j = 2; j <= n*2; j+=2)
			{
				GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
				sphere.transform.position = new Vector3((X+j), (i+Y), 0);
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
