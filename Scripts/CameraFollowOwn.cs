using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    // Use this for initialization
    [SerializeField]
    Transform target;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 direction = new Vector3(target.transform.position.x, 0, 0);
        direction = transform.TransformDirection(direction);
        transform.position = new Vector3(direction.x, transform.position.y,transform.position.z);

        
	}
}
