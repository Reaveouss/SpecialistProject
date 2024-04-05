using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExpManager : MonoBehaviour
{
    [SerializeField] float rawExp = 10f;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            collision.SendMessageUpwards("ExpAdded", rawExp, SendMessageOptions.DontRequireReceiver);
            Destroy(this.gameObject);
        }
    }
}
