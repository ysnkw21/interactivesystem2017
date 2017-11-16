using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HpCircle : MonoBehaviour {

	public float time;
	public Image gaugeCtrl;
	public Text text;

	private float change;

	void Start () {
		change = time / 0.75f;
		text.gameObject.GetComponent<Text>().enabled = false;
	}

	void Update (){
		if (time > 0) {
			gaugeCtrl.fillAmount -= 1.0f / change * Time.deltaTime;
			time -= 1.0f / 1.0f * Time.deltaTime;
		} else {
			Game.setLoseFlag (true);
			text.gameObject.GetComponent<Text>().enabled = true;
			StartCoroutine (toResultScene(4.0f));
		}
	}

	private IEnumerator toResultScene(float waitTime){
		yield return new WaitForSeconds (waitTime);
		SceneManager.LoadScene ("result_scnece");
	}

}
