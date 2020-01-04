using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
	private Rigidbody body;
	public int speed;
	public int count;
	public Text countLabel;
	public Text win;

	void Start()
	{
		body = GetComponent<Rigidbody>();
		count = 0;
		win.text = "";
		UpdatePoints();
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

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag("PickUp"))
		{
			other.gameObject.SetActive(false);
			count = count + 1;
			UpdatePoints();
		}
	}

    private void UpdatePoints()
	{
		countLabel.text = "Points: " + count.ToString();
        if(count >= 10) win.text = "You Win!";
	}

}
