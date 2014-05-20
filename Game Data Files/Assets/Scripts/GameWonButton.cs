using UnityEngine;
using System.Collections;

public class GameWonButton : MonoBehaviour {
	
	void OnGUI() {
		if (GUI.Button (new Rect(320,450,150,100), "Menu"))
		{
			Application.LoadLevel(0);
		}
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
