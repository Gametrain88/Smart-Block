using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooter : MonoBehaviour {

    // Use this for initialization
    GameObject _player;
    float shootCounter = 5;
    public GameObject bomb;
	void Start () {
        _player = GameObject.Find("Player");
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        
        shootCounter -= 1 * Time.deltaTime;
        if (shootCounter <= 0)
        {
            FireatHim();
            shootCounter = 3;
        }

	}

    Vector3 AnalyzeHim()
    {
        //Catch the player's position and calculate the trajectory that the bomb should travel. And also move to the player's x and y
        
        Vector3 trajectory = new Vector3(_player.transform.position.x, _player.transform.position.y, _player.transform.position.z);
        return trajectory;
    }

    void FireatHim()
    {
        //grab the trajectory form AnalyzeHim() and instatiate a bomb that travels in his direction
        transform.position = new Vector3(_player.transform.position.x, _player.transform.position.y, transform.position.z);

        GameObject bombPrefab = Instantiate(bomb,
            new Vector3(transform.position.x + 2, transform.position.y, -9), 
            Quaternion.identity);

        Rigidbody bombRb = bombPrefab.GetComponent<Rigidbody>();
        Vector3 direction = transform.forward;
        bombRb.AddForce(direction * 5000);
    }
}
