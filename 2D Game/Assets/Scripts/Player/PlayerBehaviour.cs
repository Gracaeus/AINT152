using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerBehaviour : MonoBehaviour {
	
	public Slider healthBar;
	public int playerHealth = 100;
	public int currentPlayerHealth;
	public Image fillimage;
	public Color fullHealth = Color.red;
	public Color ZeroHealth= Color.black;
	public bool isDead;

	public void Awake()
	{
		
		currentPlayerHealth = playerHealth;
		SetHealthUI ();
		isDead = false;

	}
	// Use this for initialization
	public void PlayerTakeDamage(int damage)
	{
		currentPlayerHealth -= damage;
		//print ("player hurt " + playerHealth);
		SetHealthUI ();
		if (currentPlayerHealth <=0 && !isDead)
		{
			Death ();
		}
	}
	private void SetHealthUI()
	{
		healthBar.value = currentPlayerHealth;
		fillimage.color = Color.Lerp (ZeroHealth, fullHealth, currentPlayerHealth / playerHealth);
	}
	private void Death()
	{
		isDead = true;
		print ("player dead");
		gameObject.SetActive (false);
		SceneManager.LoadScene (2);
	}



		
}
