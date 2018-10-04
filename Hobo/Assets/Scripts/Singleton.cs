using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Singleton是单例的模板化实现
public class Singleton<T> where T : new()
{
    private static readonly T _Instance = new T();
    protected Singleton()
    {
        if (null != _Instance)
        {
            //ERROR
            Debug.LogError("ERROR: _Instance != null");
        }
    }
    public static T Inst
    {
        get
        {
            return _Instance;
        }
    }
}