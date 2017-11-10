using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalSet : MonoBehaviour {

	public GameObject obj;
	public List<Vector3> itemVector = new List<Vector3>();
	private int randomPos;
	private int row = 0;
	private int colum = 0;
	private float initx = -42.5f;
	private float initz = 42.5f;

	// Use this for initialization
	void Start () {
		for (int i = 0; i < 18*17; i++) {
			if (colum % 18 == 0) {
				row++;
				colum = 0;
			}
			itemVector [i] = new Vector3 (initx + colum * 5.0f, 1, initz - row * 5.0f);
			colum++;
		}

		randomPos = Random.Range (0, 18 * 17);
		Instantiate (obj, itemVector [randomPos], Quaternion.identity);
	}

	void FixedUpdate (){
		//Instantiate (obj, itemVector [randomPos], Quaternion.identity);
	}
}
