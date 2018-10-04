using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // record current mapPos
    Vector2 startMapPos = new Vector2(0, 0);
    Vector2 currentMapPos;

  	// Use this for initialization
	void Start ()
    {
        currentMapPos = startMapPos;
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            if (MapManager.LegalWorldPos(mousePos))
            {
                Vector2 mapPos = MapManager.WorldPosToMap(mousePos);
                if (Math.Abs(mapPos.y - currentMapPos.y) + Math.Abs(mapPos.x - currentMapPos.x) == 1)
                {
                    this.transform.localPosition = MapManager.MapPosToWorld(mapPos);
                    currentMapPos = mapPos;
                }
            }
            else
            {
                Debug.Log("Illegal!");
            }
        }
	}
}
