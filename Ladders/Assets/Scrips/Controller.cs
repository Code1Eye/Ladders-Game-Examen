using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Controller : MonoBehaviour {
	private Score scoreMemory;
	public int score = 0;
	public Text scoreTxt;
	public GameObject goal;

	void Start () {
		scoreTxt.text = "Score: " + score.ToString();
		scoreMemory = GameObject.Find("scoreMemory").GetComponent<Score>();
	}
	
	// Update is called once per frame
	void Update () {
		scoreTxt.text = "Score: " + score.ToString();
		scoreMemory.setScore(score);

		if(score >= 2){
			goal.active = true;
		}else{
			goal.active = false;
		}
	}

	public int getScore(){
		return score;
	}
	public void setScore(int x){
		score = x;
	}
}
