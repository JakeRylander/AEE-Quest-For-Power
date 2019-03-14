using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    [SerializeField] 
    private float speed = 5.0f; //speed for player

    [SerializeField]
    private float jump_velocity = 5.0f; //jump velocity for player

    [SerializeField]
    private float fallMulti = 0.5f; //speed at which player falls 
    private float smolJmpMulti = 1.5f; //how high player jumps

    [SerializeField]
    private GameObject whiphandle;

    [SerializeField]
    private GameObject thewhip;

    [SerializeField]
    private GameObject enemy;

    private float kbforce = 10.0f;

    private Rigidbody2D rb;

    private Animator animator;

    private float h_input;
    private bool grounded;

    private bool spawned = false;

    public int hearts = 3;

	// Use this for initialization
	void Start () {
        //transform.position = new Vector3(0, -2.50f, 0);
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
        Attack();
    }

    private void FixedUpdate()
    {
        Move();
        animator.SetBool("Grounded", grounded);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == ("Ground") && !grounded)
        {
            grounded = true;
        }
    }

    private void Move () {
		if (StageControl.instance.current_event == 2) {
			h_input = Input.GetAxis ("Horizontal");
			if (h_input != 0) {
				animator.SetTrigger ("isMoving");
			}


			if (rb.velocity.y < 0) {
				//Apply fall multiplier
				rb.velocity += Vector2.up * Physics2D.gravity.y * (fallMulti - 1);
			} else if (rb.velocity.y > 0 && !Input.GetKey (KeyCode.Space)) {
				//Apply small jump multiplier
				rb.velocity += Vector2.up * Physics2D.gravity.y * (smolJmpMulti - 1);
			}

			if (Input.GetKeyDown (KeyCode.Space) && grounded) {
				//Jump
				animator.SetTrigger ("isJumping");
				rb.velocity = Vector2.up * jump_velocity;
				grounded = false;

			}
		}
	}

    private void Attack(){
        if (Input.GetKeyDown(KeyCode.S)){
            // Attack with spark wire
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                Instantiate(thewhip, transform.position + new Vector3(-3.15f, 0.8f, 0), Quaternion.Euler(0, 180, 0));
            }

            else
            {
                Instantiate(thewhip, transform.position + new Vector3(3.15f, 0.8f, 0), Quaternion.identity);
            }
        }

        else if (Input.GetKeyUp(KeyCode.S))
        {
            Destroy(GameObject.Find("Whip(Clone)"));
        }
    }

    public void Damage()
    {
        //rb.AddForce(-h_input * kbforce * -1.0f, ForceMode2D.Impulse);
        hearts--;
        if (hearts < 1)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "PatrolPoint")
        {
            if (!spawned)
            {
                Instantiate(enemy, new Vector3(Random.Range(8f,40f), -1.37f, 0), Quaternion.identity);
                spawned = true;
            }
        }
    }
}
