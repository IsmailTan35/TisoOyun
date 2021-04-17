using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Transform[] spawnLokasyonlari;
    public float spawnSuresi = 5f;
    public float kalanSure;
    public GameObject meteorObjesi;


    private void Start()
    {
        kalanSure = 0f;
    }

    private void Update()
    {
        if (kalanSure > 0)
        {
            kalanSure = kalanSure - Time.deltaTime;
        }
        else
        {
            int rastgeleSayi = Random.Range(0, spawnLokasyonlari.Length);
            Vector3 baslangicPos = spawnLokasyonlari[rastgeleSayi].position;
            if(rastgeleSayi == spawnLokasyonlari.Length-1)
            {
                rastgeleSayi = 0;
            }
            else
            {
                rastgeleSayi++;
            }
            Vector3 bitisPos = spawnLokasyonlari[rastgeleSayi].position;

            Instantiate(meteorObjesi, new Vector3(Random.Range(baslangicPos.x, bitisPos.x), Random.Range(baslangicPos.y, bitisPos.y), 0), Quaternion.identity, null);
            kalanSure = spawnSuresi;
        }
    }

}
