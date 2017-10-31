using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour {

	private void OnTriggerEnter(Collider hitCollider){

		Debug.Log ("OnTriggerEnter");

		if (hitCollider.tag == "Player")
			Game.setGoalFlag();
	}
		
}