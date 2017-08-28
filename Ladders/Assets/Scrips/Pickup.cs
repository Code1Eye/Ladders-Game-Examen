using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour {
	int score;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void pickup(){
		score = GameObject.Find("Controller").GetComponent<Controller>().getScore();
		GameObject.Find("Controller").GetComponent<Controller>().setScore(score + 1);
		Destroy(gameObject);
	}

	void OnTriggerEnter2D(Collider2D other){
		if(other.name == "Player"){
			pickup();
		}
	}
}
