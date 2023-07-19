using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PMagicSystem : MonoBehaviour
{
    [SerializeField] private Transform _castPoint;
    private PlayerInput _playerInput;
    [SerializeField] private List<Spell> _spells = new List<Spell>(5);

    private void Awake()
    {
        _playerInput = new PlayerInput();
        _playerInput.CastSystem.FirstSpell.performed += _ => CastSpell(0); // Проблема в самом скиле
        _playerInput.CastSystem.SecondSpell.performed += _ => CastSpell(1);
        _playerInput.CastSystem.UltimateSpell.performed += _ => CastSpell(2);
        _playerInput.CastSystem.PrimarySpell.performed += _ => CastSpell(3);
        _playerInput.CastSystem.SecondarySpell.performed += _ => CastSpell(4);
    }

    private void OnEnable()
    {
        _playerInput.CastSystem.Enable();
    }

    private void OnDisable()
    {
        _playerInput.CastSystem.Disable();
    }

    private Transform GetSelfTransform()
    {
        return transform;
    }

    private void CastSpell(int numSpell)
    {
        _spells[numSpell].Cast();
    }


}
