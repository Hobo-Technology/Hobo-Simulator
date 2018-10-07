using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatCharacterControl : MonoBehaviour {

    public float moveMaxSpeed;
    public float rotateSpeed;
    public float moveForce;

    private Rigidbody2D thisRigidbody;

	// Use this for initialization
	void Start () 
    {
        thisRigidbody = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () 
    {
        // move
        Vector2 force = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")) * moveForce;
        thisRigidbody.AddForce(force);
        if(thisRigidbody.velocity.magnitude > moveMaxSpeed)
        {
            thisRigidbody.velocity = thisRigidbody.velocity.normalized * moveMaxSpeed; 
        }


        // rotation
        float rotateCoef = 0;
        if (Input.GetKey(KeyCode.J)) rotateCoef += -1;
        if (Input.GetKey(KeyCode.K)) rotateCoef += 1;
        transform.Rotate(0, 0, rotateCoef * rotateSpeed * Time.deltaTime);
	}
}
