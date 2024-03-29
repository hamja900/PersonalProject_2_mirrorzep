using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum StatsChangeType
{
    Add,
    Multiple,
    Override,
}

[Serializable]
public class CharacterStats 
{
    public StatsChangeType statsChangeType;
    [Range(1,100)]public int maxHealth;
    [Range(1, 20)] public float speed;


    public AttackSO attackSO;

}
