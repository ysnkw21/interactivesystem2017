using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class carrot : MonoBehaviour {

	Slider _slider;
	public Sprite img;
	private GameObject obj;
	private Image image;

	// Use this for initialization
	void Start () {
		// スライダーを取得する
		_slider = GameObject.Find("VitB1Bar").GetComponent<Slider>();
		obj = GameObject.Find("VirusImgB1").gameObject as GameObject;
		image = obj.GetComponent<Image> ();
	}

	// Update is called once per frame
	void Update () {

	}

	void OnCollisionEnter(Collision collision) {
		//衝突判定
		if (collision.gameObject.tag == "Player") {
			Destroy (this.gameObject);
			_slider.value -= 15;
		}
		if (_slider.value == 0) {
			image.sprite = img;
		}
	}
}