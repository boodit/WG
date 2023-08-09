using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatus : MonoBehaviour ,IDamageable,IHealing
{
    [SerializeField]private enum bodyType
    {
        Base,
        Armored
    }
    [SerializeField]private bodyType _bodyType;
    [SerializeField]private int _health = 1;
    private int _armor = 1;
    public int Health => _health;
    
    public void TakeDamage(int damage)
    {
        if (damage < 0)
            damage = -damage;
        if (_bodyType == bodyType.Base)
        {
            _health -= damage; 
        }
        else if(_bodyType == bodyType.Armored)
        {
            _health -= damage / 2;
            _armor -= 1;
        }
        Debug.Log("Больно");
    }

    public void TakeHeal(int heal)
    {
        if (heal < 0)
            heal = -heal;
        _health += heal;
    }
}
