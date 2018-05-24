using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieBehaviour : MonoBehaviour
{

    public int health = 10;
	public Door door;
	private  Transform  player;
	private Transform Door;

	void Start(){
		if (GameObject.FindWithTag ("Player")) {
			player = GameObject.FindWithTag ("Player").transform;

			GetComponent<MoveTowardsObject> ().target = player;
			GetComponent<SmoothLookAtTarget2D> ().target = player;
		}
	}
    // Use this for initialization
    public void TakeDamage(int damage)
    {
		
        health -= damage;
		print (health);
        if (health <= 0)
        {
            Destroy(gameObject);
			door.killCount += 1;
			print ("Kill Count");
        }
    }
}

