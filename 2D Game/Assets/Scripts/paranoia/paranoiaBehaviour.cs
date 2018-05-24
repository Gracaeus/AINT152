using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paranoiaBehaviour : MonoBehaviour {
	public int health = 100;
	private  Transform  player;
	public Transform[] spawnPoints;
	public GameObject boss;
	public bool spawned = false;

	void Awake(){
		int spawnPointIndex = Random.Range (0, spawnPoints.Length);
		print ("Enemy spawned");
		Instantiate (boss, spawnPoints [spawnPointIndex].position, spawnPoints [spawnPointIndex].rotation);
	}
	void Start(){
		if (GameObject.FindWithTag ("Player")) {
			player = GameObject.FindWithTag ("Player").transform;
			GetComponent<SmoothLookAtTarget2D> ().target = player;
		}
		/*if (!spawned) {
			int spawnPointIndex = Random.Range (0, spawnPoints.Length);
			print ("Enemy spawned");
			Instantiate (boss, spawnPoints [spawnPointIndex].position, spawnPoints [spawnPointIndex].rotation);
			spawned = true;
		}*/

	}
	
	public void TakeDamage(int damage)
	{

		health -= damage;
		print (health);
		if (health <= 0) {
			Destroy (gameObject);
		} else {

		}
	}

	void Relocate(){
	}
		
}
