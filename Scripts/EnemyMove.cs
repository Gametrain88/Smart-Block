using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour {

    // Use this for initialization
    [Range(10, 100)] public float speed;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position -= new Vector3(speed*Time.deltaTime, 0, 0);
        
        
	}

    void OnCollisionEnter(Collision other)
    {
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
