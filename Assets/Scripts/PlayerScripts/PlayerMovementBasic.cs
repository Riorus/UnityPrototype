using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementBasic : MonoBehaviour {
    
    public float speed = 2.0f;
    public float jumpForce = 10.0f;
    public int jumpLimit = 2;

    private Rigidbody2D body;
    private int jumps = 0;

	// Use this for initialization
	void Start () {
        body = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        float moveH = Input.GetAxis("Horizontal");
        bool jump = Input.GetButtonDown("Jump");

        float moveV = 0.0f;
        if (jump && jumps < jumpLimit)
        {
            jumps++;
            moveV = 1.0f * jumpForce;
        }

        Vector2 movement = new Vector2(moveH * speed, moveV);

        body.AddForce(movement);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Floor" || collision.gameObject.tag == "SceneObject")
        {
            jumps = 0;
        }
    }
}
