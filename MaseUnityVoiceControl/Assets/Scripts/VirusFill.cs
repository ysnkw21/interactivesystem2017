using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VirusFill : MonoBehaviour {

	public float plusHeight;
	private float fallValue;

	// Use this for initialization
	void Start () {
		fallValue = -(1.0f / 1.0f * Time.deltaTime);
		transform.position += new Vector3 (0f, plusHeight, 0f);
	}
	
	// Update is called once per frame
	void Update () {
		if(transform.position.y >= 295f)
			transform.position += new Vector3 (0f, fallValue, 0f);
	}
}
