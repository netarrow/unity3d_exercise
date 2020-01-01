using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	private Rigidbody body;
	public int speed;

    void Start()
	{
		body = GetComponent<Rigidbody>();
	}

    // Update is called once per frame
    void Update()
    {
        
    }

	void FixedUpdate()
	{
		float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

		Vector3 v = new Vector3(moveHorizontal, 0.0f, moveVertical);

		body.AddForce(v * speed);

	}

}
