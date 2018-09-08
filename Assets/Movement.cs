using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {
	public float speed;
	public float jumpPower;
	public Rigidbody rb;
	private bool isGrounded;

	
	
	// Use this for initialization
	void Start () {
		speed = 8;
		jumpPower = 10;
		rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void FixedUpdate()
	{
		//transform.Translate(Input.GetAxis("Horizontal") * speed * Time.deltaTime, Input.GetAxis("Jump") * jumpPower * Time.deltaTime, Input.GetAxis("Vertical") * speed * Time.deltaTime);

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
