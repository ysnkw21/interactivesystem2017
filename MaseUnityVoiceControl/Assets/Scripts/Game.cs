using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour {

	private static bool goalFlag = false;
	
	public static void setGoalFlag(){
		if (!goalFlag)
			goalFlag = true;
		else
			goalFlag = false;
		
		Debug.Log ("setGoalFlag" + goalFlag);

		return;
	}

	public static bool getGoalFlag(){
		return goalFlag;
	}
}
