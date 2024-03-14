using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public GameObject Player;
    Vector3 directionVector;
    Rigidbody2D rigidbody;
    float moveSpeed = 10f;
    float rotateSpeed = 6f;
    float turnAmount;

    private void Start()
    {
        Player = GameObject.FindWithTag("Player");
        rigidbody = GetComponent<Rigidbody2D>();
        transform.Rotate(Vector3.back, 180f);
    }
    private void Update()
    {
        directionVector = Player.transform.position - transform.position;
        turnAmount = Mathf.Atan2(directionVector.y, directionVector.x) * Mathf.Rad2Deg;
        turnAmount = Mathf.LerpAngle(rigidbody.rotation, turnAmount, rotateSpeed * Time.deltaTime);
        rigidbody.rotation = turnAmount;
        rigidbody.MovePosition(transform.position + (transform.right * moveSpeed * Time.deltaTime));
    }
}
