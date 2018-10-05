using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatCharacterControl : MonoBehaviour {

    private Rigidbody2D rigidbody;
	// Use this for initialization
	void Start () {
        rigidbody = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        // move
        rigidbody.AddForce(new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")));

        // rotation
        if (Input.GetMouseButton(0))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector3 thisPos = this.transform.position;
            float targetAngle = Mathf.Atan2(mousePos.y - thisPos.y, mousePos.x - thisPos.x);
            float origAngle = this.transform.eulerAngles.y;
            Debug.Log(Mathf.Rad2Deg * targetAngle);
            Debug.Log(this.transform.eulerAngles.y);
            this.transform.Rotate(0, 0, Mathf.Rad2Deg * targetAngle - this.transform.eulerAngles.z);

            //Vector3 relativePos = mousePos - transform.position;
            //Quaternion rotation = Quaternion.LookRotation(relativePos);
            //transform.rotation = rotation;

        }
	}
}
