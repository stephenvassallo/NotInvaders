using UnityEngine;
using System.Collections;

public class EnemyShooting : MonoBehaviour {
	
	public GameObject Bomb = null;
	public float timeBetweenShotsMin = 0.0f;
	public float timeBetweenShotsMax = 6.0f;
	private float _nextShot = 0f;	
	
	
	void Start() {
		//This will make the invaders not start shooting immediately.
		_nextShot = Time.time + Random.Range (1.0f, 3.0f);
	}
	
		
	// Update is called once per frame
	void Update () 
	{
		if(Time.time > _nextShot) 
		{
			//Asign new next shot
			_nextShot= Time.time + Random.Range (timeBetweenShotsMin, timeBetweenShotsMax);
			
			//Fire the Projectile
			Instantiate(Bomb, transform.position, transform.rotation);
		}
	}
}
