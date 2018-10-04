using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
  	// Use this for initialization
	void Start ()
    {
    	
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            if (MapManager.LegalWorldPos(mousePos))
            {
                Debug.Log("Position = " + MapManager.WorldPosToMap(mousePos).ToString());
                Vector2 mapPos = MapManager.WorldPosToMap(mousePos);
                this.transform.localPosition = MapManager.MapPosToWorld(mapPos);
            }
            else
            {
                Debug.Log("Illegal!");
            }
        }
	}
}
