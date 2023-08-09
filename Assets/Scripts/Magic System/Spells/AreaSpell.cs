using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaSpell : Spell
{
    [Header("Spell Atribute")] 
    [SerializeField] private AtributeSpell _atribute;
    
    [Header("Common")]
    private int _damagePerSecond;
    [SerializeField] private bool _gizmosDraw = false;

    [Header("Mask")] 
    [SerializeField] private LayerMask _searchLayerMask;
    [SerializeField] private LayerMask _obstacleLayerMask;

    [Header("Overlap Area")] 
    [SerializeField] private Transform _overlapStartPoint;
    [SerializeField] private Vector3 _offset;
    [SerializeField] private float _sphereRadius = 1f;

    [Header("Obstacles")]
    [SerializeField] private bool _considerObstacles;

    private readonly Collider[] _overlapResult = new Collider[30];
    private int _overlapCountResult;
    private float cooldownDuration; 
    private bool isOnCooldown = false;  
    private float cooldownTimer = 0f;

    private void Awake()
    {
        cooldownDuration = _atribute.Cooldown;
        _damagePerSecond = _atribute.Damage;
    }
    
    public override void Cast()
    {
        if (isOnCooldown)
        {
            Debug.Log("Заклинание на перезарядке");
            return;
        }

        if (TryFindAttackEnemy())
        {
            TryAttackEnemy();
        }

        StartCooldown();
    }

    private void StartCooldown()
    {
        isOnCooldown = true;
        _gizmosDraw = false;
        cooldownTimer = cooldownDuration;
    }

    private void Update()
    {
        if (isOnCooldown)
        {
            cooldownTimer -= Time.deltaTime;
            if (cooldownTimer <= 0f)
            {
                isOnCooldown = false;
                _gizmosDraw = true;
            }
        }
    }

    private bool TryFindAttackEnemy()
    {
        var position = _overlapStartPoint.TransformPoint(_offset);
        _overlapCountResult = OverlapSphere(position);
        return _overlapCountResult > 0;
    }

    private void TryAttackEnemy()
    {
        for (int i = 0; i < _overlapCountResult; i++)
        {
            
            if (_overlapResult[i].CompareTag("Player"))
            {
                continue;
            }
            if (_overlapResult[i].TryGetComponent(out IDamageable damageable) == false)
            {
                continue;
            }

            if (_considerObstacles)
            {
                var startPointPosition = _overlapStartPoint.position;
                var colliderPosition = _overlapResult[i].transform.position;
                var hasObstacle = Physics.Linecast(startPointPosition, colliderPosition, _obstacleLayerMask.value);
                if (hasObstacle)
                {
                    continue;
                }
            }
            damageable.TakeDamage(_damagePerSecond);
        }
    }
    private int OverlapSphere(Vector3 position) 
    {
        return Physics.OverlapSphereNonAlloc(position, _sphereRadius, _overlapResult, _searchLayerMask.value);
    }
    private void OnDrawGizmosSelected() 
    {
        if (_gizmosDraw)
        {
            Gizmos.color = Color.cyan;
            Gizmos.DrawWireSphere(transform.position, _sphereRadius);   
        }

        
    
    }
}
