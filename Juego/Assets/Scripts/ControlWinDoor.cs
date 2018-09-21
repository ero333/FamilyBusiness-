﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlWinDoor : MonoBehaviour {

    public GameObject[] enemies;
    bool win = false;

    // Use this for initialization
    void Start () {
        GameObject[] dogs = GameObject.FindGameObjectsWithTag("Dog");
        GameObject[] heavies = GameObject.FindGameObjectsWithTag("Heavy");
        GameObject[] enemies1 = GameObject.FindGameObjectsWithTag("Enemy");
        enemies = new GameObject[dogs.Length + heavies.Length + enemies1.Length];
        dogs.CopyTo(enemies, 0);
        heavies.CopyTo(enemies, dogs.Length);
        enemies1.CopyTo(enemies, (dogs.Length) + (heavies.Length));
    }
	
	// Update is called once per frame
	void Update () {
        win = areAllEnemiesDead();

        if (win == true)
        {
            Destroy(this.gameObject);
        }        

	}

    public bool areAllEnemiesDead()
    {
        for (int x = 0; x < enemies.Length; x++)
        {
            if (enemies[x].tag != "Dead")
            {
                return false;
            }
        }
        return true;
    }

}
