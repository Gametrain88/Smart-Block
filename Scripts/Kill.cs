using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kill : MonoBehaviour {
    public float counter;

	// Use this for initialization
	void Start () {
        DestroyIt();
		
	}
	
	// Update is called once per frame
	void Update () {
        
		
	}

    void DestroyIt()
    {
        Destroy(this.gameObject, counter);
    }
}
