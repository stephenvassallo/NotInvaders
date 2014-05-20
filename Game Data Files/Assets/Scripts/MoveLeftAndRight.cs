using UnityEngine;
using System.Collections;

public class MoveLeftAndRight : MonoBehaviour
{
	
	public static float speed = 15f; //Speed of the game
	public float rightLimitation, leftLimitation, downLimitation, upLimitation = 0.0f;
	
	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		
		Vector3 viewPos = Camera.main.WorldToViewportPoint(transform.position);
		viewPos.x = Mathf.Clamp01(viewPos.x);
		viewPos.y = Mathf.Clamp01(viewPos.y);
		transform.position = Camera.main.ViewportToWorldPoint(viewPos);
		
		Vector3 newPosition = transform.position;
		newPosition.x = newPosition.x + Input.GetAxis ("Horizontal") * speed * Time.deltaTime; //This will be adding + 1 or - 1 movement to left or right. Time.Detla adjusts the speed of the game.
		transform.position = newPosition;
				
	
	}

	public static void IncreaseSpeed()
	{
		speed += 100;
	}
}
