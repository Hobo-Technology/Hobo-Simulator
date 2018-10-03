using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// cao zuo
public class Player : MonoBehaviour {

    Vector2Int viewPosition;


	// Use this for initialization
	void Start () {
    	
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetMouseButton(0)) {
            Vector3 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            pos.z = transform.position.z;
            transform.position = pos;

            // Cell 坐标 
        }	

        ///
	}
}
