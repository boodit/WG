using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Attribute", menuName = "Spell/Attribute ")]
public class AtributeSpell : ScriptableObject
{
    [Header("Description")]
    public string Name;
    public Sprite Sprite;

    [Header("Ability")] 
    public float Cooldown;
    [Min(0f)]public int Damage;
    
}
