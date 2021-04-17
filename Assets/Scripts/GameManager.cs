using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public GameObject menu;
    public void OyunBitti()
    {
        menu.SetActive(true);
    }

    public void AnaMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void Basla()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(1);
    }

    public void OyundanCik()
    {
        Application.Quit();
    }
}
