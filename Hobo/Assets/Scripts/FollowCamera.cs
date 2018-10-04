﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour 
{

    public Transform target;
    private Vector3 offset;

	// Use this for initialization
	void Start () 
    {
        offset = this.transform.position - target.position;	
	}
	
	// Update is called once per frame
	void Update () 
    {
        this.transform.position = offset + target.position;
	}
}
