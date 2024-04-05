using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class BulletManager : MonoBehaviour
{
    [SerializeField] float Speed = 3f;
    [SerializeField] float rawDamage = 7f;
    [SerializeField] GameObject BulletPrefab;
    public float BulletTimer = 10f;

    void Start()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 direction = (mousePosition - this.transform.position).normalized;
        Rigidbody2D rb = BulletPrefab.GetComponent<Rigidbody2D>();
        rb.velocity = direction * Speed;
     }
    private void Update()
    {
        BulletTimer = BulletTimer - Time.deltaTime;
        if (BulletTimer <= 0)
        {
            Destroy(this.gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {
            collision.SendMessageUpwards("Morder", rawDamage, SendMessageOptions.DontRequireReceiver);
            Destroy(gameObject);
        }
    }

}
