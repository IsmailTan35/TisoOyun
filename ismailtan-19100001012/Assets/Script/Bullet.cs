using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 10;
    float sec = 5f;
    public Rigidbody2D rb;
    void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag != "red")
        {
            (gameObject.GetComponent<PolygonCollider2D>()).enabled = true;
        }

    }
    void OnCollisionExit2D(Collision2D collision)
    {
        (gameObject.GetComponent<PolygonCollider2D>()).enabled = true;

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag =="red")
        {
            (gameObject.GetComponent<PolygonCollider2D>()).enabled = false;
        }
        else (gameObject.GetComponent<PolygonCollider2D>()).enabled = true;
    
    }

    void Update()
    {
        transform.parent = null;
        rb.MovePosition(transform.position + (transform.up * speed*Time.deltaTime));

        if (sec > 0)
        {
            sec -= Time.deltaTime;
        }
        else
        {
            Destroy(gameObject);
        }
       
    }
}
