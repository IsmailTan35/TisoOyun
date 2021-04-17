using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemiHareketi : MonoBehaviour
{
    public float speed = 0.1f;
    public float rotasyonHizi = 1f;
    public float atesHizi = 0.4f;
    float cooldown = 0f;
    public GameObject lazerObjesi;
    public Transform[] lokasyonlar;
    void Start()
    {
        Debug.Log("Çalýþtý");
    }

    void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.W))
        {
            transform.position += transform.up * Time.deltaTime * speed;
        }

        if(Input.GetKey(KeyCode.S))
        {
            transform.position -= transform.up * Time.deltaTime * speed;
        }

        if(Input.GetKey(KeyCode.A))
        {
            transform.Rotate(new Vector3(0,0,1) * rotasyonHizi * Time.deltaTime);
        }

        if(Input.GetKey(KeyCode.D))
        {
            transform.Rotate(new Vector3(0,0, -1) * rotasyonHizi * Time.deltaTime);
        }

        if(Input.GetKey(KeyCode.Space))
        {
            if (!(cooldown > 0))
            {
                AtesEt();
            }
        }
        cooldown -= Time.deltaTime;
    }

    void AtesEt()
    {
        cooldown = atesHizi;
        Instantiate(lazerObjesi, lokasyonlar[0].position, transform.rotation);
        Instantiate(lazerObjesi, lokasyonlar[1].position, transform.rotation);
    }

    

}
