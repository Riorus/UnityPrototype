using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAttackScript : MonoBehaviour {

    public GameObject fireball;
    public GameObject iceball;
    private List<GameObject> Projectiles = new List<GameObject>();

    public float projectileVel = 3.0f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        if (Input.GetButtonDown("Fire1")){
            GameObject spell;
            if (Random.value >= 0) spell = fireball;
            else spell = iceball;
            FireSpell(spell);
        }
	}

    void FireSpell(GameObject spell)
    {
        Vector2 target = Camera.main.ScreenToWorldPoint(new Vector2(Input.mousePosition.x, Input.mousePosition.y));
        Vector2 myPos = new Vector2(transform.position.x, transform.position.y);
        Vector2 direction = target - myPos;
        direction.Normalize();
        Quaternion rotation = Quaternion.Euler(0, 0, Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg);
        GameObject projectile = (GameObject)Instantiate(spell, myPos, rotation);
        projectile.GetComponent<Rigidbody2D>().velocity = direction * projectileVel;
    }
}
