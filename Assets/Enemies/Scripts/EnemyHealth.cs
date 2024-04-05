using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] float HitPoints;
    [SerializeField] float MaxHitPoints = 10;
    [SerializeField] GameObject EXP;
    Vector3 expSpawn;

    void Start()
    {
        HitPoints = Random.Range(MaxHitPoints/2, MaxHitPoints);
    }
    void Morder(float rawDamage)
    {
        HitPoints -= rawDamage;

        if (HitPoints <= 0)
        {
            OnDeath();
        }
    }
    private void OnDeath()
    {
        Instantiate(EXP);
        expSpawn = transform.position;
        EXP.transform.position = expSpawn;
        Destroy(this.gameObject);
    }
}
