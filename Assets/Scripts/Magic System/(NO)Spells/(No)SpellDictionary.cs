using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NOSpellDictionary : ScriptableObject
{
    public List<Spell> spells = new List<Spell>(5);

    // Получение заклинания по индексу или по типу, если требуется
    public Spell GetSpell(int index)
    {
        if (index >= 0 && index < spells.Count)
        {
            return spells[index];
        }

        return null;
    }
}
