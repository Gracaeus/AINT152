using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehaviour : MonoBehaviour {

	private  Transform  player;

	// Use this for initialization
	void Start () {

		if (GameObject.FindWithTag ("Player")) {
			player = GameObject.FindWithTag ("Player").transform;

			GetComponent<SmoothFollow2D> ().target = player;
		}
	}

}
