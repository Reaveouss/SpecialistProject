using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletManager : MonoBehaviour
{
    [SerializeField] float Speed = 3f;
    [SerializeField] float rawDamage = 7f;
    
    void Update()
    {
        transform.position += transform.forward * Time.deltaTime * Speed;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag != "Player" && collision.tag != "Bullet")
        {
            collision.SendMessageUpwards("Morder", rawDamage, SendMessageOptions.DontRequireReceiver);
            Destroy(gameObject);
        }
    }

}
