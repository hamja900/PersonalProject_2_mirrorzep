using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FingerShooting : MonoBehaviour
{
    private ProjectileManager _projectileManager;
    private DefaultCharacterController _controller;

    [SerializeField]private Transform projectileSpawnPosition;
    private Vector2 _aimDirection = Vector2.right;



    private void Awake()
    {
        _controller = GetComponent<DefaultCharacterController>();
    }
    // Start is called before the first frame update
    void Start()
    {
        _projectileManager = ProjectileManager.Instance;
        _controller.OnAttackEvent += OnShoot;
        _controller.OnLookEvent += OnAim;
    }

    private void OnAim(Vector2 newAimDirection)
    {
        _aimDirection = newAimDirection;
    }

    private void OnShoot(AttackSO attackSO)
    {
        RangedAttackData rangedAttackData = attackSO as RangedAttackData;
        float projectilesAngleSpace = rangedAttackData.multipleProjectilesAngle;
        int numberOfProjectilesPerShot = rangedAttackData.numberofProjectilesPerShot;
        float minAngle = -(numberOfProjectilesPerShot / 2f) * projectilesAngleSpace + 0.5f * rangedAttackData.multipleProjectilesAngle;
        for (int i = 0; i < numberOfProjectilesPerShot; i++)
        {
            float angle = minAngle + projectilesAngleSpace * i;
            float randomSpread = Random.Range(rangedAttackData.spread,rangedAttackData.spread);
            angle += randomSpread;
            CreateProjectile(rangedAttackData,angle);
        }
        
    }

    private void CreateProjectile(RangedAttackData rangedAttackData,float angle)
    {
        _projectileManager.ShootFinger(projectileSpawnPosition.position,RotateVector2(_aimDirection,angle), rangedAttackData );

     
    }
    private static Vector2 RotateVector2(Vector2 v, float degree)
    {
        return Quaternion.Euler(0,0,degree)*v;
    }

}
