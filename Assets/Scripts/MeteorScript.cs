using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorScript : MonoBehaviour
{
    public float speed = 5f;
    public float step;
    Vector3 sonPozisyon;
    private void Start()
    {
        sonPozisyon = transform.position * -1;
    }
    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, sonPozisyon, speed * Time.deltaTime);

        if(Vector3.Distance(transform.position, sonPozisyon) < 1)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            Destroy(collision.gameObject);
            Time.timeScale = 0f;
            GameObject.Find("Game Manager").GetComponent<GameManager>().OyunBitti();
        }
    }
}
