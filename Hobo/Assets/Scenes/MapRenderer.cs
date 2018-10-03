using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapRenderer : MonoBehaviour {
    
    public GameObject cellPrefab;
	// Use this for initialization
	void Start () {
        for (int i = 0; i < 10; ++i)
        {
            for (int j = 0; j < 10; ++j)
            {
                Transform trans = transform;
                Vector3 pos = trans.position;
                pos.x = j * 0.8f;
                pos.y = i * 0.8f;
                trans.position = pos;
                Instantiate(cellPrefab, pos, Quaternion.identity);
            }
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
