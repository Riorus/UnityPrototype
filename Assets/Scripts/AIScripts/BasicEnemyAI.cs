﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicEnemyAI : MonoBehaviour {

    public static float health = 100.0f;

	// Use this for initialization
	void Start () {
		
	}

    void TakeDamage(float dmg)
    {
        health -= dmg;
        if (health <= 0) Debug.Log("DEAD!!!!");
    }
}
