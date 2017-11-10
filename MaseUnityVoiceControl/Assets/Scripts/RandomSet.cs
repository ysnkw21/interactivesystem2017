using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSet : MonoBehaviour {

	public GameObject obj;
	public static GameObject _obj;
	public List<Vector3> itemVector = new List<Vector3>();
	public static List<int> randomList = new List<int> ();
	public static bool hitFlag = false;
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
			itemVector [i] = new Vector3 (initx + colum * 5.0f, 0, initz - row * 5.0f);
			colum++;
		}

		while (true) {
			randomPos = Random.Range (0, 18 * 17);
			if (randomList.Contains (randomPos)) {
				continue;
			}
			break;
		}

		randomList.Add(randomPos);

		_obj = Instantiate (obj, itemVector [randomPos], Quaternion.identity) as GameObject;
	}

	void Update (){
		if(hitFlag){
			Debug.Log ("OrangeDestory");
			Destroy(_obj);
			hitFlag = false;
		}
	}

	public static void hitOrange(){
		hitFlag = true;
		return;
	}
}
