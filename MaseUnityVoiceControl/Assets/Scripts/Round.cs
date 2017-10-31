using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Round : MonoBehaviour {

	private float rotationNow = 0f;
	public float rotationAdd = 90f;

	// Update is called once per frame
	void Update () {
		rotationNow += (rotationAdd * Time.deltaTime);
		transform.rotation = Quaternion.Euler (0, rotationNow, 0);
	}
}
