using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour {

	private static bool goalFlag = false;
	private static bool loseFlag = false;
	private static bool vitC1 = false;
	private static bool vitA = false;
	private static bool vitB1 = false;
	private static int car_count = 3;
	private static int ora_count = 3;
	private static int egg_count = 3;

	//Set Value
	public static void setGoalFlag(bool flag){
		goalFlag = flag;
		return;
	}

	public static void setLoseFlag(bool flag){
		loseFlag = flag;
		return;
	}

	public static void setVitC1(bool flag){
		vitC1 = flag;
		return;
	}

	public static void setVitA(bool flag){
		vitA = flag;
		return;
	}

	public static void setVitB1(bool flag){
		vitB1 = flag;
		return;
	}

	//Increase value
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

	//Get Value
	public static bool getGoalFlag(){
		return goalFlag;
	}

	public static bool getLoseFlag(){
		return loseFlag;
	}

	public static bool getVitC1(){
		return vitC1;
	}

	public static bool getVitA(){
		return vitA;
	}

	public static bool getVitB1(){
		return vitB1;
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
