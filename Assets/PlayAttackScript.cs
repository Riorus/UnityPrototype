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
            if (Random.value >= 0.5) spell = fireball;
            else spell = iceball;
            FireSpell(spell);
        }

        ProgressSpells();
	}

    void FireSpell(GameObject spell)
    {
        GameObject gObj = (GameObject)Instantiate(spell, transform.position, Quaternion.identity);
        Projectiles.Add(gObj);
    }

    void ProgressSpells()
    {
        for(int i = 0; i < Projectiles.Count; i++)
        {
            GameObject flyingSpell = Projectiles[i];

            
        }
    }
}
