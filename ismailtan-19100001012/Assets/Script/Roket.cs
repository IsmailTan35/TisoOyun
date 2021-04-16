using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Roket : MonoBehaviour
{
    public float speed = 5;
    public float rotationSpeed = 1;
    bool fire = false;
    float sec = 5f;
    float simSec = .5f;
    [SerializeField]
    Rigidbody2D Deneme;
    void Start()
    {
       
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (fire==true)
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }        
    }
    
    void FixedUpdate()
    {
        Deneme.MovePosition(transform.position + (transform.up * speed * Time.deltaTime));
        speed += speed * Time.deltaTime;
        speed = Mathf.Clamp(speed, 1f, 5f);
        if (transform.rotation.eulerAngles.z < 45 || transform.rotation.eulerAngles.z > 355)
        {
            transform.Rotate(new Vector3(0,0,1 * rotationSpeed * Time.deltaTime));
            rotationSpeed += rotationSpeed * Time.deltaTime;
        }

        if(sec > 0)
        {
            sec -= Time.deltaTime;
            if(simSec > 0)
            {
                simSec-= Time.deltaTime;
            }
            else
            {
                print("sin");
            }
        }
        else
        {
            Destroy(gameObject);
            fire = false;
        }
    }
}
