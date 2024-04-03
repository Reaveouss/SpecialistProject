using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackGun : MonoBehaviour
{
    [SerializeField] float rawDamage = 7f;
    [SerializeField] float delayTimer = 0.5f;
    [SerializeField] GameObject Bullet;
    [SerializeField] GameObject Player;
    float tick;
    void Start()
    {
        
    }

    void Update()
    {
        if (attackReady())
        {
            Instantiate(Bullet);

        }
    }
    bool attackReady()
    {
        if (tick < delayTimer)
        {
            tick += Time.deltaTime;
            return false;
        }
        return true;
    }
}
