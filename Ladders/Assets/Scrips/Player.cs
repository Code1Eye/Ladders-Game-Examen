using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
	private bool lookingLeft = true;
	private Animation anim;
	private SpriteRenderer spriteRenderer;
	private float climbVelocity;
	private float gravityStore;
	private Rigidbody2D myRigidbody2D;
    private int timer;

	public float speed;
	public float climbSpeed;
	public bool onLadder; 

	// Use this for initialization
	void Start () {
		spriteRenderer = GetComponent<SpriteRenderer>();
		GetComponent<SpriteRenderer>().color = Color.green;
		anim = GetComponent<Animation>();
		myRigidbody2D = GetComponent<Rigidbody2D>();
		gravityStore = myRigidbody2D.gravityScale;
        timer = 0;
    }

    // Update is called once per frame
    void Update () {
		if(Input.GetKey(KeyCode.A)){
			GetComponent<Animator>().speed = 1;
			transform.position -= new Vector3(speed * Time.deltaTime, 0.0f, 0.0f);
			spriteRenderer.flipX = false;
		}else if(Input.GetKey(KeyCode.D)){
			GetComponent<Animator>().speed = 1;
			transform.position += new Vector3(speed * Time.deltaTime, 0.0f, 0.0f);
			spriteRenderer.flipX = true;
		}else{
			GetComponent<Animator>().speed = 0;
		}

        if (timer == 0) {
            if (Input.GetKey(KeyCode.LeftControl) && Input.GetKey(KeyCode.Equals))
            {
                if (speed < 5)
                {
                    speed++;
                    timer = 70;
                }
            }

            if (Input.GetKey(KeyCode.LeftControl) && Input.GetKey(KeyCode.Minus))
            {
                if (speed > 1)
                {
                    speed--;
                    timer = 70;
                }
            }
            
        }


        if (onLadder){
			myRigidbody2D.gravityScale = 0f;
			climbVelocity = climbSpeed * Input.GetAxisRaw("Vertical");

			myRigidbody2D.velocity = new Vector2(myRigidbody2D.velocity.x, climbVelocity);
		}

		if(!onLadder){
			myRigidbody2D.gravityScale = gravityStore;
		}

        if (timer >= 1)
        {
            timer--;
        }
        Debug.Log(timer);
    }

    

	
}
