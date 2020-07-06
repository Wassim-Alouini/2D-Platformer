using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LethalScript : MonoBehaviour
{
    public float damage;
    public bool push;
    public float force = 300f;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        push = true;
        Debug.Log("Hit");
        if(collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<HealthManager>().TakeDamage(damage);
            Debug.Log("Damaged");
            if (push)
            {
                Vector2 pushDirection = collision.transform.position - transform.position;
                collision.gameObject.GetComponent<Rigidbody2D>().AddForce(pushDirection.normalized * force);
                Debug.Log("Pushed");
                push = false;
            }
        }
    }
}
