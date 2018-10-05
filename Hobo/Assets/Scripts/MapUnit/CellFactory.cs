using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CellFactory : Singleton<CellFactory>
{
    public Cell GenerateCell(Vector2 position, BuildingType generateBuildingType = BuildingType.RANDOM)
    {
        Cell cell = new Cell(position, generateBuildingType);
        return cell;
    }
}
