using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hitItem : MonoBehaviour {

	void OnCollisionEnter(Collision col) {
		if (col.gameObject.CompareTag("Player")) {
			Destroy(this.gameObject);
		}
	}

	private void OnTriggerEnter(Collider hitCollider){
		if (hitCollider.tag == "Player") {
			Debug.Log ("hitCollider.tag == Orange");
			RandomSet.hitOrange ();
		}
	}
}
