using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class resultButton: MonoBehaviour {

	public void OnResultButtonClicked(){
		SceneManager.LoadScene ("start_scene");
	}
}
