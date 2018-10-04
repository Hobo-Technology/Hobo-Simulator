using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapManager : MonoBehaviour
{
    public static MapManager Instance;

    const int CELL_NUM = 10;
    const float CELL_LENGTH = 1f;

    public GameObject cellPrefab;
    Cell [,] map = new Cell[CELL_NUM, CELL_NUM];

	void Start ()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Debug.LogError("MapManager Instance Error");
        }
        
        // Create map
        for (int y = 0; y < CELL_NUM; ++y) 
        {
            for (int x = 0; x < CELL_NUM; ++x)
            {
                map[y, x] = CellFactory.Inst.GenerateCell();
            }
        }

        // Display map
        for (int y = 0; y < CELL_NUM; ++y)
        {
            for (int x = 0; x < CELL_NUM; ++x)
            {
                GameObject temp = Instantiate(cellPrefab, this.transform, true);
                temp.transform.localPosition = MapPosToWorld(new Vector2(x, y)); //localPosition vs Position
            }
        }
    }

    public static Vector2 MapPosToWorld(Vector2 mapPos)
    {
        return mapPos * CELL_LENGTH;
    }

    public static bool LegalWorldPos(Vector2 worldPos)
    {
        Vector2 mapPos = WorldPosToMap(worldPos);
        if (mapPos.x < 0 || mapPos.x >= CELL_NUM || mapPos.y < 0 || mapPos.y >= CELL_NUM)
        {
            return false;
        }
        else return true;
    }
    
    public static Vector2 WorldPosToMap(Vector2 worldPos)
    {
        Vector2 ajustPos = worldPos + new Vector2(CELL_LENGTH * 0.5f, CELL_LENGTH * 0.5f) - (Vector2)MapManager.Instance.transform.position;
        
        int y = (int)Math.Floor(ajustPos.y / CELL_LENGTH);
        int x = (int)Math.Floor(ajustPos.x / CELL_LENGTH);
        return new Vector2(x, y);
    }
}
