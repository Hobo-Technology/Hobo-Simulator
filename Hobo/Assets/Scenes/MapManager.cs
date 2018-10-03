using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Item
{
    
}

class MoveObject: Item 
{

}

class Building : Item
{
    
}

class Cell
{
    List<Item> arrayHuman = new List<Item>();
    List<Item> arrayBuilding = new List<Item>();

    public static Cell GenerateCell()
    {
        Cell cell = new Cell();
        return cell;
    }
}

public class MapManager : MonoBehaviour {
    enum MAP_TYPE
    {
        TYPE_ASAFAS,
        TYPE_NUM=1
    }

    const int SIZE = 100;
    Cell [,] map = new Cell[SIZE, SIZE];

	void Start () {
        for (int i = 0; i < SIZE; ++i) 
        {
            for (int j = 0; j < SIZE; ++j)
            {
                 map[i, j] = Cell.GenerateCell();
            }
        }
            
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
