using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementBasic : MonoBehaviour {
    
    public float speed = 2.0f;
    public float jumpForce = 10.0f;

    private Rigidbody2D body;

	// Use this for initialization
	void Start () {
        body = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        float moveH = Input.GetAxis("Horizontal");
        bool jump = Input.GetButtonDown("Jump");

        float moveV = 0.0f;
        if(jump) moveV = 1.0f * jumpForce;

        Debug.Log(moveH);

        Vector2 movement = new Vector2(moveH * speed, moveV);

        Debug.Log(movement);

        body.AddForce(movement);
    }
}
