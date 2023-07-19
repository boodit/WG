using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour, IDamageable
{
    public void TakeDamage(float damage)
    {
        Debug.Log("Aй " + damage);
    }
}
