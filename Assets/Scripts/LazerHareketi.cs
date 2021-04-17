using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LazerHareketi : MonoBehaviour
{
    public float lazerHizi = 5f;
    private void Update()
    {
        transform.position += transform.up * lazerHizi * Time.deltaTime;
    }


    private void OnTriggerEnter2D(Collider2D carpilanObje)
    {
        if(carpilanObje.tag == "Duvar")
        {
            Destroy(this.gameObject);
        }

        if(carpilanObje.tag == "Meteor")
        {
            GameObject.Find("Game Manager").GetComponent<Skor>().SkorEkle(10);
            Destroy(carpilanObje.gameObject);
            Destroy(this.gameObject);
        }
    }
}
