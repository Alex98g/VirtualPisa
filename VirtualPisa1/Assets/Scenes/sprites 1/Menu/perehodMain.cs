using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class perehodMain : MonoBehaviour
{
    public void Show_begin() //начать
    {
        SceneManager.LoadScene("Модули");
    }
    public void Show_avtor()
    {
        SceneManager.LoadScene("Автор");
    }
    public void Vs() //выход
    {
        Application.Quit();
    }
    public void Show_MainMenu()
    {
        SceneManager.LoadScene("Главное меню");
    }
}
