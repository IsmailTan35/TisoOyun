using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed = 5;
    [SerializeField]
    public GameObject[] roketler;
    public GameObject Bullet;
    Rigidbody2D Deneme;
    int seciliRoket = 0;
    float atesHizi = .3f;
    float atesZaman;

    void Start()
    {
        atesZaman = atesHizi;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(1, 0, 0) * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += new Vector3(-1, 0, 0) * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.W))
        {

            transform.position += new Vector3(0, 1, 0) * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += new Vector3(0, -1, 0) * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(0,0,1);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(0, 0, -1);
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            if (seciliRoket<2)
            {
                roketler[seciliRoket].transform.parent = null;
                (roketler[seciliRoket].GetComponent<Rigidbody2D>()).simulated = true;
                roketler[seciliRoket].GetComponent<Roket>().enabled = true;
                seciliRoket++;
            }         
        }
        if (Input.GetMouseButton(0))
        {
            if(atesZaman > 0 )
            {
                atesZaman = atesZaman - Time.deltaTime;
            }
            else
            {
                Instantiate(Bullet, transform.position, transform.rotation);
                atesZaman = atesHizi;
            }
        }
    }
}
