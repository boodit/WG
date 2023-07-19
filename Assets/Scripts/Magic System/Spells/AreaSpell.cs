using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaSpell : Spell
{
    [Header("Spell Atribute")] 
    [SerializeField] private AtributeSpell _atribute;
    
    [Header("Common")]
    [SerializeField, Min(0f)] private float _damage;
    
    
    private float cooldownDuration; 
    private bool isOnCooldown = false;  
    private float cooldownTimer = 0f;

    private void Awake()
    {
        _damage = _atribute.Damage;
    }
}
