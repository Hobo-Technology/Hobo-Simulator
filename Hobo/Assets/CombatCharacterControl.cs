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
        rigidbody.AddForce(new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")));

	}
}
