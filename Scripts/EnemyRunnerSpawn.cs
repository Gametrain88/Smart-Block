using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRunnerSpawn : MonoBehaviour {

    // Use this for initialization
    public GameObject EnemyRunner;
    float counter = 2;


    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        counter -= 1 * Time.deltaTime;
        if (counter <= 0)
        {
            SpawnRunner();
            counter = 3;
        }
	}

    void SpawnRunner()
    {
        
        Instantiate(EnemyRunner, new Vector3(transform.position.x - 3, -9f, transform.position.z), Quaternion.identity);

    }
}
