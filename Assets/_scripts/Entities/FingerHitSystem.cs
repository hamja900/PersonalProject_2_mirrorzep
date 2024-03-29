using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FingerHitSystem : MonoBehaviour
{
    [SerializeField] private float healthChangeDelay = .5f;

    private CharacterStatsHandler _statsHandler;
    private float _timeSinceLastChange = float.MaxValue;

    public event Action OnDamage;
    public event Action OnHeal;
    public event Action OnDeath;
    public event Action OnInvincibilityEnd;

    public AudioClip tingle;
    public AudioSource audioSource;

    public float CurrentHealth { get; private set; }
    public float MaxHealth => _statsHandler.CurrentStats.maxHealth;

    private void Awake()
    {
        _statsHandler = GetComponent<CharacterStatsHandler>();
    }
    private void Start()
    {
        CurrentHealth = _statsHandler.CurrentStats.maxHealth;
    }
    private void Update()
    {
        if(_timeSinceLastChange < healthChangeDelay)
        {
            _timeSinceLastChange += Time.deltaTime;
            if(_timeSinceLastChange>=healthChangeDelay )
            {
                OnInvincibilityEnd?.Invoke();
            }
        }
        
    }
    public bool ChangeHealth(float change)
    {
        if(change == 0 ||_timeSinceLastChange <healthChangeDelay)
        {
            return false;
        }
        _timeSinceLastChange = 0f;
        CurrentHealth += change;
        CurrentHealth = CurrentHealth > MaxHealth ? MaxHealth : CurrentHealth;
        CurrentHealth = CurrentHealth < 0 ? 0 : CurrentHealth;

        if (change >0)
        {
            OnHeal?.Invoke();
        }
        else
        {
            OnDamage?.Invoke();
            audioSource.PlayOneShot(tingle);
        }
        if (CurrentHealth <= 0f)
        {
            CallDeath();
        }
        return true;
    }
    private void CallDeath()
    {
        OnDeath?.Invoke();
    }
}

