using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum BuildingType
{
    SCHOOL,                 //学校
    HOSPITAL,               //医院
    LANDFILL,               //垃圾场
    SHAMBLES,               //废墟
    POLICE_STATION,         //警察局
    CONVINENENT_STORE,      //便利店
    SUPERMARKET,            //超市
    HOBO_STATION,           //丐帮总舵（善良）
    HOBO_FACTORY,           //丐帮总舵（邪恶）

    RANDOM
}

public class Cell
{
    const int BUILDING_COLOR_NUM = 6;
    static Color[] BuildingColors =
    {
        new Color(129f/255, 194f/255, 214f/255),
        new Color(129f/255, 146f/255, 214f/255),
        new Color(217f/255, 179f/255, 230f/255),
        new Color(220f/255, 247f/255, 161f/255),
        new Color(131f/255, 252f/255, 216f/255),
        new Color(220f/255, 130f/255, 161f/255),
    };
    GameObject cellPrefab = GameObject.Find("CellPrefab");
    BuildingType buildingType;
    List<Item> arrayHuman = new List<Item>();
    List<Item> arrayBuilding = new List<Item>();

    public Cell(Vector2 position, BuildingType generateBuildingType = BuildingType.RANDOM)
    {
        if (generateBuildingType == BuildingType.RANDOM)
        {
            generateBuildingType = (BuildingType)UnityEngine.Random.Range(0, (int)BuildingType.RANDOM - 1);
        }
        buildingType = generateBuildingType;
        GameObject.Instantiate(cellPrefab);
        cellPrefab.transform.parent = MapManager.Instance.transform;
        cellPrefab.transform.localPosition = position;

        cellPrefab.GetComponent<SpriteRenderer>().color = BuildingColors[(int)buildingType % BUILDING_COLOR_NUM];

        //switch (buildingType)
        //{
        //    case BuildingType.SCHOOL:
        //        cellPrefab.GetComponent<SpriteRenderer>().color = Color.green;
        //        break;
        //    case BuildingType.HOSPITAL:
        //        cellPrefab.GetComponent<SpriteRenderer>().color = Color.red;
        //        break;
        //    case BuildingType.LANDFILL:
        //        cellPrefab.GetComponent<SpriteRenderer>().color = Color.yellow;
        //        break;
        //    case BuildingType.POLICE_STATION:
        //        cellPrefab.GetComponent<SpriteRenderer>().color = Color.blue;
        //        break;
        //    default:
        //        cellPrefab.GetComponent<SpriteRenderer>().color = Color.black;
        //        break;
        //}
    }
}