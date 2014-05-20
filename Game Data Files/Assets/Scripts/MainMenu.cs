using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {
	
		
	void OnGUI() {
		if (GUI.Button (new Rect(170,475,150,100), "Play"))
		{
			Application.LoadLevel(1);
		}
		
		if (GUI.Button (new Rect(440,475,150,100), "Quit"))
		{
			 Application.Quit();
		}
	}

	// Use this for initialization
	void Start () {
	
		GameData.currentLevel=1;
		GameData.currentLevelEnemies=GameData.level1Enemies;
		EnterName.playerName= "";
		GameData.score=0;
		Shoot.shots=0;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
