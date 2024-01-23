using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefaultAnimationController : DefaultAnimation
{
    private static readonly int IsWalking = Animator.StringToHash("IsWalking");
    private static readonly int IsHit = Animator.StringToHash("IsHit");

    private FingerHitSystem _hitSystem;
    private DefaultMovement _movement;
    protected override void Awake()
    {
        base.Awake();
        _hitSystem = GetComponent<FingerHitSystem>();
        _movement = GetComponent<DefaultMovement>();
    }

    // Start is called before the first frame update
    void Start()
    {
        if(_movement != null)
        {
            controller.OnMoveEvent += Move;
        }
        
        
        if(_hitSystem != null)
        {
            _hitSystem.OnDamage += Hit;
            _hitSystem.OnInvincibilityEnd += InvincibilityEnd;
        }
    }

    private void Move(Vector2 obj)
    {
        animator.SetBool(IsWalking, obj.magnitude > .5f);
    }

    private void Hit()
    {
        animator.SetBool(IsHit, true);
    }
    private void InvincibilityEnd()
    {
        animator.SetBool(IsHit, false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
