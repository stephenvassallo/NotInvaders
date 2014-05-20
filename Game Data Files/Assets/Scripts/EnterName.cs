using UnityEngine;
using System.Collections;

public class EnterName : MonoBehaviour {
	
	public static string playerName = "";

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnGUI (){

		playerName = GUI.TextField(new Rect(275,300, 200, 20), playerName);

		if (GUI.Button (new Rect(300,400,150,100), "Play"))
		{	

			Application.LoadLevel(2);
		}
	}
}
