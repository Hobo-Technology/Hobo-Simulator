using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatCharacterControl : MonoBehaviour {

    public float moveMaxSpeed;
    public float moveForce;

    private Rigidbody2D theRigidbody;

	// Use this for initialization
	void Start () 
    {
        theRigidbody = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () 
    {
        // move
        Vector2 force = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")) * moveForce;
        theRigidbody.AddForce(force);
        if(theRigidbody.velocity.magnitude > moveMaxSpeed)
        {
            theRigidbody.velocity = theRigidbody.velocity.normalized * moveMaxSpeed; 
        }

        // rotation
        if (Input.GetMouseButton(0))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector3 thisPos = this.transform.position;
            float targetAngle = Mathf.Atan2(mousePos.y - thisPos.y, mousePos.x - thisPos.x);
            this.transform.Rotate(0, 0, Mathf.Rad2Deg * targetAngle - this.transform.eulerAngles.z);
        }
	}
}
