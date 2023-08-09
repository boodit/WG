using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour, IDamageable
{
    public void TakeDamage(int damage)
    {
        Debug.Log("Aй " + damage);
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("aaaaaaaa");
        if (other.transform.TryGetComponent(out IDamageable idamageable))
        {
            idamageable.TakeDamage(1);
        } 
    }

    private void OnCollisionEnter(Collision other)
    {
        
    }
}
