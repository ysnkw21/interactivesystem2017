using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class carrot : MonoBehaviour {

	Slider _slider;

	// Use this for initialization
	void Start () {
		// スライダーを取得する
		_slider = GameObject.Find("carrotBar").GetComponent<Slider>();
	}

	// Update is called once per frame
	void Update () {

	}

	void OnCollisionEnter(Collision collision) {
		//衝突判定
		if (collision.gameObject.tag == "Player") {
			Destroy (this.gameObject);
			_slider.value += 15;
		}
	}
}