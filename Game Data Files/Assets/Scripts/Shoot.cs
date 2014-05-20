using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour
{
	
	public GameObject laser;
	public GameObject rocket;
	public GameObject specialshot;
	public static int shots;
	
	// Use this for initialization
	void Start ()
	{
		shots = 0;
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.Space)) { //This makes the player shoot when they hit Z only, and "GetKeyDown" Fires once "GetKey" is an automatic machine gun.
		
						Instantiate (laser, transform.position, transform.rotation);
						shots++;
				}
	
	else if (Input.GetKeyDown (KeyCode.X)) {					
			Instantiate (rocket, transform.position, transform.rotation);
			shots++;

		}
	
	else if (Input.GetKeyDown (KeyCode.C)) {					
			Instantiate (specialshot, transform.position, transform.rotation);
			shots++;
		}

	}	
}
