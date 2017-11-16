using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class egg : MonoBehaviour {

	Slider _slider;
	public Sprite img;
	private GameObject obj;
	private Image image;

	// Use this for initialization
	void Start () {
		// スライダーを取得する
		_slider = GameObject.Find("VitABar").GetComponent<Slider>();
		obj = GameObject.Find("VirusImgA").gameObject as GameObject;
		image = obj.GetComponent<Image> ();
	}

	void OnCollisionEnter(Collision collision) {
		//衝突判定
		if (collision.gameObject.tag == "Player") {
			Destroy (this.gameObject);
			_slider.value -= 100;
		}
		if (_slider.value == 0) {
			image.sprite = img;
			Game.setVitA (true);
			Goal.isCheckedVit ();
		}
	}
}