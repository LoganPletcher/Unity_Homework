using UnityEngine;
using System.Collections;

public class Unity_Sphere_Grid : MonoBehaviour
{
    void Start ()
    {
		int X = 10;
		int Y = 10;
		for (int i = 1; i <= 5; i++)
		{
			for (int j = 1; i <= 5; i++)
			{
				GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
				sphere.transform.position = new Vector3((j*X), (i*Y), 10);
			}
		}

    }

    void Update ()
    {

    }
}