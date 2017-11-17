using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour {

	public static void isCheckedVit(){
		if (Game.getVitC1 () && Game.getVitA () && Game.getVitB1 ()) {
			Game.setGoalFlag (true);
			Game.setVitC1 (false);
			Game.setVitA (false);
			Game.setVitB1 (false);
		}
	}
		
}