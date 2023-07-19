using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Spell : MonoBehaviour
{
    public virtual AtributeSpell Attribute { get; set; }

    public virtual void Cast()
    {
        Debug.Log("Nothing");
    }
}
