using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "DefaultAttackData", menuName = "Controller/Attacks/Ranged", order = 1)]

public class RangedAttackData : AttackSO
{
    [Header("RangedAttackData")]
    public string bulletNameTag;
    public float duration;
    public float spread;
    public int numberofProjectilesPerShot;
    public float multipleProjectilesAngle;
    public Color projectileColor;
}
