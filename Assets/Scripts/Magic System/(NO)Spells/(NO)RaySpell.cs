using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class NORaySpell 
{
    public float damagePerSecond = 2f;
    public float beamRange = 10f;
    public float cooldownDuration = 0.1f; // Длительность перезарядки в секундах
    private bool isOnCooldown = false; // Флаг перезарядки
    private float cooldownTimer = 0f; // Таймер перезарядки
    public static event Func<Transform> onCasting;
    private Transform transform;

    public void Cast()
    {
        transform = onCasting?.Invoke();
        // Проверяем, не находится ли заклинание на перезарядке
        if (isOnCooldown)
        {
            Debug.Log("Заклинание на перезарядке");
            return;
        }

        // Выполняем заклинание

        // Получаем все объекты, попавшие в прямоугольную область перед вами
        Collider[] colliders = Physics.OverlapBox(transform.position, new Vector3(beamRange, beamRange, 0f) / 2f, transform.rotation);

        // Проходимся по каждому объекту и проверяем, является ли он IDamageable
        foreach (Collider collider in colliders)
        {
            IDamageable damageable = collider.GetComponent<IDamageable>();
            if (damageable != null)
            {
                // Наносим урон объекту
                damageable.TakeDamage(damagePerSecond);
            }
        }

        // Начинаем перезарядку
        StartCooldown();
    }

    private void StartCooldown()
    {
        isOnCooldown = true;
        cooldownTimer = cooldownDuration;
    }

    private void Update()
    {
        // Проверяем, находится ли заклинание на перезарядке
        if (isOnCooldown)
        {
            // Уменьшаем таймер перезарядки
            cooldownTimer -= Time.deltaTime;

            // Проверяем, достиг ли таймер перезарядки значения ниже или равного нулю
            if (cooldownTimer <= 0f)
            {
                // Закончилась перезарядка
                isOnCooldown = false;
            }
        }
    }

    private void OnDrawGizmosSelected()
    {
        // Отрисовываем прямоугольную область в редакторе Unity
        Gizmos.color = Color.red;
        Gizmos.DrawWireCube(transform.position, new Vector3(beamRange, beamRange, 0f));
    }
}
