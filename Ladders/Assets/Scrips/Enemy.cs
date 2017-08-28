using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {
	private Player player;
	private ButtonMgr buttonMgr;
    private Vector3 prevVel;
    private Vector3 curVel;

    public SpriteRenderer spriteRenderer;

    public int speed = 0;

	void Start () {
        //player = GameObject.Find("Player").GetComponent<Player>();
		buttonMgr = GameObject.Find("buttonMgr").GetComponent<ButtonMgr>();
        //spriteRenderer = GetComponent<SpriteRenderer>();
        prevVel = transform.position;

    }
     
     void Update () {

        if (Input.GetKey(KeyCode.LeftControl) && Input.GetKey(KeyCode.T))
        {
            GetComponent<BoxCollider2D>().enabled = false;
        }

        if (Input.GetKey(KeyCode.LeftControl) && Input.GetKey(KeyCode.I))
        {
            gameObject.active = false;
        }

        //transform.position = Vector2.MoveTowards(transform.position, player.transform.position, speed*Time.deltaTime);
        curVel = transform.position;
        

        if (curVel.x < prevVel.x)
        {
            spriteRenderer.flipX = false;
            
        }

        if(curVel.x > prevVel.x)
        {
            spriteRenderer.flipX = true;
        }

        prevVel = transform.position;
        
    }

	 void OnTriggerEnter2D(Collider2D other){
		if(other.name == "Player"){
			Debug.Log("Trigger");
			buttonMgr.LoadBtn(4);
		}
	}

}
