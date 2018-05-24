using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnClickLoad : MonoBehaviour {

	public void LoadScene (){
		//SceneManager.LoadSceneAsync (sceneIndex);
		SceneManager.LoadSceneAsync (1);
	}
}
