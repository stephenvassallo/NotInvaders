using UnityEngine;
using System.Collections;

public class GameData : MonoBehaviour
{
	public static int score = 0; //Static - Grants us the possibility to access the score outside of the Game Data.
	public static bool gameOver = false;
	public float rightLimitation, leftLimitation, downLimitation, upLimitation = 0.0f;
	//Total enemies for level 1
	public static int level1Enemies = 4;
	//Total enemies for level 2
	public static int level2Enemies = 5;
	//Total enemies for level 3
	public static int level3Enemies = 6;
	//Current level (1, 2 or 3)
	public static int currentLevel = 1;
	//Current amount of enemies
	public static int currentLevelEnemies = 4;
	public static bool showInitialScreen = true;
	
	
	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{			
		if (gameOver) {								
			if (Input.GetKeyDown (KeyCode.Y)) {
				gameOver = false;
				currentLevel = 1;
				currentLevelEnemies = level1Enemies;
				Application.LoadLevel ("InvadersLevel1");							
			} else if (Input.GetKeyDown (KeyCode.N)) {
				Application.LoadLevel ("MainMenu");
			}
		} else if (currentLevelEnemies == 0) {			
			if (currentLevel == 1) {										
				if (Input.GetKeyDown (KeyCode.L)) {
					currentLevel = currentLevel + 1;
					currentLevelEnemies = level2Enemies;				
					Application.LoadLevel ("InvadersLevel2");
				}
			} else if (currentLevel == 2) {								
				if (Input.GetKeyDown (KeyCode.L)) {
					currentLevel = currentLevel + 1;
					currentLevelEnemies = level3Enemies;
					Application.LoadLevel ("InvadersLevel3");
				}				
			} else if (currentLevel == 3) {				
				Application.LoadLevel ("Gamewon");
			}
		}

	}
	
	void OnGUI ()
	{
		GUI.Label (new Rect (0, 0, 120, 20), "Score: " + score.ToString ());		
		GUI.Label (new Rect (100, 0, 120, 20), "Shots Fired: " + Shoot.shots.ToString ());	
		GUI.Label (new Rect (300, 0, 200, 20), "Player Name: " + EnterName.playerName);
		GUI.Label (new Rect (500, 0, 120, 20), "Level: " + currentLevel.ToString ());
		
		if (gameOver) {			
			GUI.Label (new Rect ((Screen.width - 260) / 2,(Screen.height - 20) / 2, 260, 20), "GAME OVER! Press Y to try again N to exit");
			GUI.Label (new Rect (200, 0, 120, 20), "Health: 0%");	
		} else if (currentLevelEnemies == 0) {							
			if (currentLevel == 1) {						
				GUI.Label (new Rect ((Screen.width - 230) / 2,(Screen.height - 20) / 2, 230, 20), "Level cleared. Press L to continue.");				
			} else if (currentLevel == 2) {				
				GUI.Label (new Rect ((Screen.width - 230) / 2,(Screen.height - 20) / 2, 230, 20), "Level cleared. Press L to continue.");				
			} 
		}
		else
		{
			GUI.Label (new Rect (200, 0, 120, 20), "Health: 100%");	
		}
		
	}	

	public static void IncreaseScore()
	{
		score += 1000;
	}
}
