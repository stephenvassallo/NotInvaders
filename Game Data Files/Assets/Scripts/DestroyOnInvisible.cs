using UnityEngine;
using System.Collections;

public class DestroyOnInvisible : MonoBehaviour {

	void OnBecameInvisible() //Destroys objects that are not on the screen so the game wont need more recources as it progresses.
	{
		Destroy(gameObject);
	}
	
	
}
