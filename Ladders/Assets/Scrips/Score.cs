using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	private int score;
	private Text endScore;
	
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		endScore = GameObject.Find("endScore").GetComponent<Text>();
		endScore.text = "Score: " + score.ToString();
	}

	public void setScore(int x){
		score = x;
	}

	void Awake(){
		DontDestroyOnLoad(this);
		
	}
}
