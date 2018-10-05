using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = ("RPG/Weapon"))]
public class Weapon : ScriptableObject
{
    [SerializeField] Color color;
    [Range(1,2)] public float baoji;
    [SerializeField] int attack;
    [SerializeField] GameObject weaponPrefab;
    [SerializeField] AnimationClip attackAnimation;

    public GameObject GetWeaponPrefab()
    {
        return weaponPrefab;
    }

    public AnimationClip GetAnimation()
    {
        return attackAnimation;
    }
}