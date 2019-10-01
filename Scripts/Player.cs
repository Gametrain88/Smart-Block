using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    // Use this for initialization

    float _speed = 5;
    float _fallMultiplier = 2.5f;
    float _lowJumpMultiplier = 2;
    [SerializeField] [Range(1, 10)] float _jumpVelocity = 2;
    

    Rigidbody rb;
    public int health = 100;
    CharacterController _controller;


    private void Awake()
    {
        transform.position = new Vector3(-10,-12, 25);
    }

    void Start () {
        rb = GetComponent<Rigidbody>();
        _controller = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {
        Movement();
        
    }

    void Movement()
    {
        //Only Right Movement
        float mX =  _speed * Time.deltaTime;
        float mZ = Input.GetAxis("Vertical") * _speed * Time.deltaTime;
        Vector3 pos = transform.position;
        
        
        

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = Vector3.up * _jumpVelocity;
        }
        //Better jumping
        if (rb.velocity.y < 0)
        {
            rb.velocity += Vector3.up * Physics.gravity.y * (_fallMultiplier - 1) * Time.deltaTime;

        }
        else if (rb.velocity.y > 0 && !Input.GetKey(KeyCode.Space))
        {
            rb.velocity += Vector3.up * Physics.gravity.y * (_lowJumpMultiplier - 1) * Time.deltaTime;

        }

        transform.position = new Vector3(pos.x + mX, pos.y , Mathf.Clamp(pos.z + mZ, 25, 35));
        

    }

    public void Takedamage(int damage)
    {
        health -= damage;
        
    }

    
}