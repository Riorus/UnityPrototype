using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionBehaviour : MonoBehaviour {

    public float explosionSpeed = 1.0f;
    public float explosionSize = 10.0f;
    public float damage = 50.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        transform.localScale += new Vector3(explosionSpeed, explosionSpeed);
        if(transform.localScale.x >= explosionSize)
        {
            Destroy(gameObject);
        }

        Collider2D[] collisions = Physics2D.OverlapCircleAll(transform.position, explosionSize);
        for(int i = 0; i < collisions.Length; i++)
        {
            Debug.Log(collisions[i].gameObject);
            collisions[i].gameObject.SendMessage("TakeDamage", damage);
        }
	}
}
