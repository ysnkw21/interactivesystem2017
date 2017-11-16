using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HpCircle : MonoBehaviour {

	public float time;
	public Image gaugeCtrl;
	private float change;

	void Start () {
		change = time / 0.75f;
	}

	void Update (){
		if (time > 0) {
			gaugeCtrl.fillAmount -= 1.0f / change * Time.deltaTime;
			time -= 1.0f / 1.0f * Time.deltaTime;
			Debug.Log (gaugeCtrl.fillAmount);
			Debug.Log (time);
		} else {
			SceneManager.LoadScene ("result_scnece");
		}
	}

}
