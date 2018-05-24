using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieHit : MonoBehaviour {
	public int damage = 1;

	public string damageTag = "";


	void OnTriggerStay2D (Collider2D other) {
		if (other.CompareTag(damageTag))
		{
			other.SendMessage("PlayerTakeDamage", damage);
		}

	}

	void Update () {
		
	}
}
