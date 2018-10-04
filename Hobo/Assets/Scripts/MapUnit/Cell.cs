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
    BuildingType buildingType;
    List<Item> arrayHuman = new List<Item>();
    List<Item> arrayBuilding = new List<Item>();

    public Cell(BuildingType generateBuildingType = BuildingType.RANDOM)
    {
        if (generateBuildingType == BuildingType.RANDOM)
        {
            generateBuildingType = (BuildingType)UnityEngine.Random.Range(0, (int)BuildingType.RANDOM - 1);
        }
        buildingType = generateBuildingType;
    }
}