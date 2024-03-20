using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;
using UnityEngine.UIElements;

public class EnemyMovement : MonoBehaviour
{
    public GameObject Player;
    Rigidbody2D rigidbody1;
    [SerializeField] float moveSpeed = 1f;

    private void Start()
    {
        Player = GameObject.FindWithTag("Player");
        rigidbody1 = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        rigidbody1.velocity = (Player.transform.position - transform.position).normalized * moveSpeed;
    }
}
