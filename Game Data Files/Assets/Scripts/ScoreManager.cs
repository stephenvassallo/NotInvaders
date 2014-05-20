using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {

	public int point;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter()
	{
		GameData.score += point;    //On Collision you'll add points to Game Data.
	}
}
