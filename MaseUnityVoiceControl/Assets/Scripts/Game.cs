using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour {

	private static bool goalFlag = false;
	private static bool loseFlag = false;
	private static int car_count = 3;
	private static int ora_count = 3;
	private static int egg_count = 3;
	
	public static void setGoalFlag(){
		if (!goalFlag)
			goalFlag = true;
		else
			goalFlag = false;

		return;
	}

	public static void setLoseFlag(bool flag){
		loseFlag = flag;
		return;
	}

	public static void incCarCount(){
		car_count--;
		return;
	}

	public static void incOraCount(){
		ora_count--;
		return;
	}

	public static void incEggCount(){
		egg_count--;
		return;
	}

	public static bool getGoalFlag(){
		return goalFlag;
	}

	public static bool getLoseFlag(){
		return loseFlag;
	}

	public static int getCarCount(){
		return car_count;
	}

	public static int getOraCount(){
		return ora_count;
	}

	public static int getEggCount(){
		return egg_count;
	}
}
