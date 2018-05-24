using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTowardsObject : MonoBehaviour {

    public Transform target;
    public float speed = 5.0f;
	public string playerTag = "";
	public bool targetFound = false;
	private float distance;


	/*void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag (playerTag)) {
			System.Console.WriteLine ("Entered");
			targetFound = true;
		}
	}*/
	/*void  OnTriggerStay2D(  Collider2D  other ){ 
		if (other.CompareTag (playerTag)) {
			System.Console.WriteLine ("Entered");
			targetFound = true;

		}
	}*/
	void FixedUpdate()
	{
		distance = Vector3.Distance (transform.position, target.position);
		if (distance <= 10) {
			targetFound = true;
		}
		if (targetFound == true) {
			if (GetComponent<Rigidbody2D> () != null) {
				GetComponent<Rigidbody2D> ().velocity = Vector2.zero;
				GetComponent<Rigidbody2D> ().angularVelocity = 0.0f;
			}

			transform.position = Vector3.MoveTowards (transform.position, target.position, speed * 0.01f);


		}
	}
}
