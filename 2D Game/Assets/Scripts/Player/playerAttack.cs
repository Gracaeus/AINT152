using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerAttack : MonoBehaviour {
	private bool isAttacking=false;
	Animator anim;

	void Start()
	{
		anim = GetComponent<Animator> ();
	}

	void setAttacking(){
		isAttacking = false;
	}
	void Attack () {
		isAttacking = true;
		anim.SetTrigger ("attack");
	}

	void ResetAttack()
	{
		isAttacking = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButton(0))
		{
			if (!isAttacking)
			{
				isAttacking = true;
				Invoke ("ResetAttack", 0.5f);
				Attack();
				//setAttacking ();
			}
		}
	}
}
