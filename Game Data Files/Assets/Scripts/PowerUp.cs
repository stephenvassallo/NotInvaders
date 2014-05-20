using UnityEngine;
using System.Collections;

public class PowerUp : MonoBehaviour {

	public GameObject[] gibs;
	public float explosionForce;
	public float spawnRadius = 0.0f;

	public static string selected_powerup = "";

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		System.Console.WriteLine ("Drawing...");
	}

	void OnTriggerEnter ()
	{
		foreach (GameObject gib in gibs) {
			GameObject gibInstance = Instantiate (gib, transform.position + Random.insideUnitSphere * spawnRadius, transform.rotation) as GameObject; //So the explosion will spawn where the alien was.
			gibInstance.rigidbody.AddExplosionForce (explosionForce, gibInstance.transform.position, spawnRadius);
		}
		Destroy (gameObject);	

		float selection = Random.Range(0, 100);
		if(selection <= 33)
		{
			MoveLeftAndRight.IncreaseSpeed ();
		}
		else if (selection <= 66)
		{
			GameData.IncreaseScore();
		}
		else 
		{
			LaserAI.IncreaseSpeed();
		}


		Debug.Log ("Hello", gameObject);
	}
}

