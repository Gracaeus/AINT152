using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour {

	public GameObject player;
	public Transform spawnPoint;
	// Use this for initialization
	void Start () {
		Spawn ();
	}
	
	// Update is called once per frame
	void Spawn () {
		Instantiate (player, spawnPoint.position, spawnPoint.rotation);
	}
}
