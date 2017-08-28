using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour {
	private ButtonMgr buttonMgr;
	private Controller controller;
	
	// Use this for initialization
	void Start () {
		buttonMgr = GameObject.Find("buttonMgr").GetComponent<ButtonMgr>();
		controller = GameObject.Find("Controller").GetComponent<Controller>();
	}

	void Update () {
		
	}




	
	
	void OnTriggerEnter2D(Collider2D other){
		if(other.name == "Player"){
			buttonMgr.LoadBtn(3);
		}
	}
}
