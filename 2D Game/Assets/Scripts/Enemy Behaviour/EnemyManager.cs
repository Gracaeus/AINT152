using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour {

	public PlayerBehaviour playerhealth;
	public GameObject enemy;
	public float spawnTime = 3f;
	public  Transform[] spawnPoints;
	public string playerTag = "Player";

	
	// Update is called once per frame
	void OnTriggerStay2D(Collider2D other){
		if (other.CompareTag (playerTag)) {
			InvokeRepeating ("Spawn", spawnTime, spawnTime);
		}
	}
	void OnTriggerExit2D (Collider2D other){
		CancelInvoke ("Spawn");
	}

	void Spawn () {

		if (playerhealth.currentPlayerHealth <= 0) {

			return;
		}

		int spawnPointIndex = Random.Range (0, spawnPoints.Length);
		print ("Enemy spawned");
		Instantiate (enemy, spawnPoints [spawnPointIndex].position, spawnPoints [spawnPointIndex].rotation);

	}
}
