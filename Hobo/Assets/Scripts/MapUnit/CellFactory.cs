using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CellFactory : Singleton<CellFactory>
{
    public Cell GenerateCell()
    {
        Cell cell = new Cell();
        return cell;
    }
}
