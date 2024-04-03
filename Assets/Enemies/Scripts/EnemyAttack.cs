using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    [SerializeField] float rawDamage = 1f;
    [SerializeField] float delayTimer = 0.2f;
    float tick;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player" && attackReady())
        {
            collision.SendMessageUpwards("Hit", rawDamage, SendMessageOptions.DontRequireReceiver);
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