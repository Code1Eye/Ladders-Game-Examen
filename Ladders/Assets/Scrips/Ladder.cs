using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ladder : MonoBehaviour {

	private Player thePlayer;
	private Enemy theEnemy;
	

	// Use this for initialization
	void Start () {
		thePlayer = FindObjectOfType<Player>();
	}
	
	void OnTriggerEnter2D(Collider2D other){
		if(other.name == "Player"){
			thePlayer.onLadder = true;
		}
	}

	void OnTriggerExit2D(Collider2D other){
		if(other.name == "Player"){
			thePlayer.onLadder = false;
		}
	}

}
