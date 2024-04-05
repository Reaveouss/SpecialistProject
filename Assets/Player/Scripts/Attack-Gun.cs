using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackGun : MonoBehaviour
{
    [SerializeField] float delayTimer = 0.5f;
    [SerializeField] GameObject Bullet;
    [SerializeField] GameObject Player;
    [SerializeField] Transform Curser;
    float tick;
    void Update()
    {
        if (attackReady())
        {
            Instantiate(Bullet, Curser.position, transform.rotation);
            
        }
    }
    bool attackReady()
    {
        tick += Time.deltaTime;
        if (tick > delayTimer)
        {
            tick = tick - delayTimer;
            return true;
        }
        return false;
    }
}
