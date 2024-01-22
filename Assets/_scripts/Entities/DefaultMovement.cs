using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class DefaultMovement : MonoBehaviour
{
    private DefaultCharacterController _controller;
    private CharacterStatsHandler _stats;

    private Vector2 _movementDirection = Vector2.zero;
    private Rigidbody2D _rigidbody;
    private Vector2 _knockBack = Vector2.zero;
    private float knockBackDuration = 0.0f;
    

    private void Awake()
    {
        _controller = GetComponent<DefaultCharacterController>();
        _stats = GetComponent<CharacterStatsHandler>();
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        _controller.OnMoveEvent += Move;
        
    }

    private void FixedUpdate()
    {
        ApplyMovement(_movementDirection);
        if(knockBackDuration > 0.0f)
        {
            knockBackDuration -= Time.fixedDeltaTime;
        }
    }
    private void Move(Vector2 direction)
    {
        _movementDirection = direction;
    }

    public void ApplyKnockback(Transform other, float power, float duration)
    {
        knockBackDuration = duration;
        _knockBack = -(other.position - transform.position).normalized*power;
    }

    private void ApplyMovement(Vector2 direction)
    {
        direction = direction * _stats.CurrentStats.speed;
        if(knockBackDuration > 0.0f)
        {
            direction += _knockBack;
        }

        _rigidbody.velocity = direction;
    }
}
