using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move1 : MonoBehaviour
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
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        float z = Input.GetAxis("Rotate");
        transform.position += new Vector3(transform.up.x * x + (transform.right.x * x), transform.up.y * y + (transform.right.y * y), 0) * speed * Time.deltaTime;
        transform.Rotate(0, 0, -z );

        if (Input.GetKeyUp(KeyCode.Joystick1Button6))
        {
            if (seciliRoket<2)
            {
                roketler[seciliRoket].transform.parent = null;
                (roketler[seciliRoket].GetComponent<Rigidbody2D>()).simulated=true;
                roketler[seciliRoket].GetComponent<Roket>().enabled = true;
                seciliRoket++;
            }         
        }

        if (Input.GetKey(KeyCode.Joystick1Button0))
        {
            Instantiate(Bullet, transform.position, transform.rotation);
            if (atesZaman > 0 )
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
