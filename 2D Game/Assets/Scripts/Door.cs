using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour {


	public int killCount;

	void Start () {
		killCount = 0;
	}

	void FixedUpdate () {
		if (killCount >=10) {
			Destroy(gameObject);
		}

		
	}
}
