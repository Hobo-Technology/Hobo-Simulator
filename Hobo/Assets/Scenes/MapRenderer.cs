using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapRenderer : MonoBehaviour {

    static float topPadding, leftPadding;
    static float cellWidth = 0.8f, cellHeight = 0.8f;

    public GameObject cellPrefab;
	// Use this for initialization
	void Start () {
        for (int i = 0; i < 10; ++i)
        {
            for (int j = 0; j < 10; ++j)
            {
                Transform trans = transform;
                Vector3 pos = trans.position;
                pos.x = j * cellWidth;
                pos.y = i * cellHeight;
                trans.position = pos;
                GameObject temp = Instantiate(cellPrefab, trans, true);
            }
        }
	}
	
	// Update is called once per frame
	void Update () {
	    	
	}

    static Vector2Int WorldToCellPosition(Vector2 orig) 
    {
        Vector2Int pos = new Vector2Int();
        pos.x = orig.x / 
        return pos;

    }
}
