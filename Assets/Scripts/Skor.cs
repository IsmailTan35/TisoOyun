using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Skor : MonoBehaviour
{
    public TextMeshProUGUI skorText;
    public TextMeshProUGUI menuSkorText;
    int score = 0;

    public void SkorEkle(int skor)
    {
        score += skor;
        skorText.text = "Skor: " + score;
        menuSkorText.text = "Skorunuz: " + score;
    }
}
