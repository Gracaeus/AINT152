using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelOneComplete : MonoBehaviour {
	public string player;
	void OnTriggerStay2D (Collider2D other){
		if (other.CompareTag(player)){
			SceneManager.LoadSceneAsync (3);
		}
	}
}