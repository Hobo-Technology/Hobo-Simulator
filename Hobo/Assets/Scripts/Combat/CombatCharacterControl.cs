using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatCharacterControl : MonoBehaviour {

    public float moveMaxSpeed;
    public float rotateSpeed;
    public float moveForce;

<<<<<<< HEAD
    private Rigidbody2D theRigidbody;
=======
    private Rigidbody2D thisRigidbody;
>>>>>>> e3d61b987f1b9c658987e5f7f70d7e5acbe5b08a

	// Use this for initialization
	void Start () 
    {
<<<<<<< HEAD
        theRigidbody = GetComponent<Rigidbody2D>();
=======
        thisRigidbody = GetComponent<Rigidbody2D>();
>>>>>>> e3d61b987f1b9c658987e5f7f70d7e5acbe5b08a
	}
	
	// Update is called once per frame
	void Update () 
    {
        // move
        Vector2 force = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")) * moveForce;
<<<<<<< HEAD
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
=======
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
>>>>>>> e3d61b987f1b9c658987e5f7f70d7e5acbe5b08a
	}
}
