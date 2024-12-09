using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu]
public class DataBaseManager : ScriptableObject
{
    public static DataBaseManager Instance;

    public void Init()
    {
        Instance = this;
    }

    [Header("UI")]
    public int TreeCount;
    public int StoneCount;
    public float MentalCount = 100;

    [Header("ÀÚ¿ø")]
    public Ore Wood;
    public Ore Stone;
    public Ore Mental;
}
