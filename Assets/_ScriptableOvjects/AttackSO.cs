using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "DefaultAttackData", menuName = "Controller/Attacks/Default", order = 0)]
public class AttackSO : ScriptableObject
{
    [Header("AttackInfo")]
    public float size;
    public float delay;
    public float power;
    public float speed;
    public LayerMask target;

    [Header("KnockBackInfo")]
    public bool isOnKnockback;
    public float knockbackPower;
    public float knockbackTime;
   
}
