using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParentDetect : MonoBehaviour
{
    private BoxCollider2D boxCollider2D;
    private new Rigidbody2D rigidbody2D;

    void Start()
    {
        boxCollider2D = GetComponent<BoxCollider2D>();
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void OnTriggerEnter2D(Collider2D collider2D)
    {
        if (collider2D.CompareTag("Bullet"))
        {
            rigidbody2D.constraints = ~RigidbodyConstraints2D.FreezePosition;
            boxCollider2D.enabled = false;
            rigidbody2D.AddForce(new Vector2(11, 3), ForceMode2D.Impulse);
        }

        if (collider2D.CompareTag("Waves"))
        {
            rigidbody2D.constraints = ~RigidbodyConstraints2D.FreezePosition;
            boxCollider2D.enabled = false;
            rigidbody2D.AddForce(new Vector2(11, 3), ForceMode2D.Impulse);
        }

        if (collider2D.CompareTag("Roots"))
        {
            rigidbody2D.constraints = ~RigidbodyConstraints2D.FreezePosition;
            boxCollider2D.enabled = false;
            rigidbody2D.AddForce(new Vector2(11, 3), ForceMode2D.Impulse);
        }

        if (collider2D.CompareTag("Explosion"))
        {
            Destroy(gameObject);
        }
    }
}
