using UnityEngine;
using System.Collections;

public class GibOnCollide : MonoBehaviour
{
	
	public GameObject[] gibs;
	public float explosionForce;
	public float spawnRadius = 0.0f;

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}

	void OnTriggerEnter ()
	{
		foreach (GameObject gib in gibs) {
			GameObject gibInstance = Instantiate (gib, transform.position + Random.insideUnitSphere * spawnRadius, transform.rotation) as GameObject; //So the explosion will spawn where the alien was.
			gibInstance.rigidbody.AddExplosionForce (explosionForce, gibInstance.transform.position, spawnRadius);
		}
		Destroy (gameObject);	
		GameData.currentLevelEnemies = GameData.currentLevelEnemies - 1;
		GameData.score += 100;
		//System.Console.WriteLine ("sssssssssssss");

		//Debug.Log ("Hello 222222222", gameObject);
	}
}
