﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision other)
    {
        //if bomb hits the player,take damage
        if (other.gameObject.tag == "Player")
        {
            Player player = other.gameObject.GetComponent<Player>();
            if (player != null)
            {
                Rigidbody playerRb = player.GetComponent<Rigidbody>();
                playerRb.AddForce(Vector3.up * 1265);
                playerRb.AddForce(Vector3.forward * 300);
                
                //player.Takedamage(25);
            }
            Destroy(this.gameObject);
        }
        
    }
}
