using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {
	public float speed;
	public float jumpPower;
	public Rigidbody rb;
	private bool isGrounded;
	private float horizontal;
	private float vertical;
	
	
	
	// Use this for initialization
	void Start () {
		speed = 8;
		jumpPower = 10;
		rb = GetComponent<Rigidbody>();	
		
		//vertical = Input.GetAxis("Vertical");
        //horizontal = Input.GetAxis("Horizontal");
	}
	
	
	void FixedUpdate()
	{
	

		//rb.velocity = new Vector3(vertical, 0f, horizontal);

		if (isGrounded)
		{
			if (Input.GetButtonDown("Jump"))
			{
				rb.velocity = new Vector3(0f, jumpPower, 0f);
			}
			
		}
	}

	void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.tag == "Ground")
		{
			isGrounded = true;
		}
		
	}
	void OnCollisionExit(Collision other)
	{
		if (other.gameObject.tag == "Ground")
		{
			isGrounded = false;
		}
		
	}
}
