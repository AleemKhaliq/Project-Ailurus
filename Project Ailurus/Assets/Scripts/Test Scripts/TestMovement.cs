using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestMovement : MonoBehaviour {

    public float boxSpeed;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        //BaseMovement();
	}

    // Fixed Update is called before every physics calculation
    private void FixedUpdate()
    {

    }

    //Base movement for testing
    void BaseMovement()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(-boxSpeed, 0, 0);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(boxSpeed, 0, 0);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(0, 0, -boxSpeed);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(0, 0, boxSpeed);
        }
    }

    void Hop()
    {

    }
}
