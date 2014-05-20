using UnityEngine;
using System.Collections;

public class EnemyAI : MonoBehaviour {
	public float speed;
	public float rightEdgePadding;
	public float leftEdgePadding;
	public float dropDistance;
	
	private int direction = 1; 
	

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		Vector3 newPosition = transform.position;
		newPosition.x += speed * direction * Time.deltaTime; //So that speed is based on time rather then frames.
		transform.position = newPosition;
		
		if(Camera.main.WorldToScreenPoint(transform.position).x > Screen.width - rightEdgePadding) //This will make so the border will change if the size of the window changes. If the Aliens hit the right border they will start moving left.
		{
			direction = -1;
			newPosition = transform.position;
			float cameraObjectZDifference = transform.position.z - Camera.main.transform.position.z;
			newPosition.x = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width,0,cameraObjectZDifference)).x;
			newPosition.y -= dropDistance;
			transform.position = newPosition;
		}
		if(Camera.main.WorldToScreenPoint(transform.position).x < 0 + leftEdgePadding) //0 Because the left hand side of the screen is always ZERO
		{
			direction = 1;
			newPosition = transform.position;
			float cameraObjectZDifference = transform.position.z - Camera.main.transform.position.z;
			newPosition.x = Camera.main.ScreenToWorldPoint(new Vector3(0,0,cameraObjectZDifference)).x;
			newPosition.y -= dropDistance;
			transform.position = newPosition;
		}
	}
}
