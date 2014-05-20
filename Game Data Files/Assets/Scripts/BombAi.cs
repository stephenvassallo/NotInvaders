using UnityEngine;
using System.Collections;


public class BombAi : MonoBehaviour {
	
	public float speed;
	
	// Use this for initialization
	void Start () {
		Vector3 newVelocity = Vector3.zero;
		newVelocity.y = speed;
		rigidbody.velocity = newVelocity;
	}
	
	// Update is called once per frame
	void Update () {
	
		//Vector3 newPosition = transform.position;
		//newPosition.y += speed * Time.deltaTime; //This will be adding + 1 or - 1 movement to left or right. Time.Detla adjusts the speed of the game.
		//transform.position = newPosition;
	}
}
