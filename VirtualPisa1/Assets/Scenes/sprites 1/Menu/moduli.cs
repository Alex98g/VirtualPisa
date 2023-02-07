using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class moduli : MonoBehaviour
{
    public GameObject info;
    bool textNotDisplayed = true;
    float timeToHideText = 0f;
    bool k,t;
    private void Start()
    {
        k = true;
        if (k == true)
        {
            info.gameObject.SetActive(k);
        }
        if (k == false)
        {
            info.gameObject.SetActive(k);
        }
        if (perehodmodul1.r == false)
        {
            info.gameObject.SetActive(perehodmodul1.r);
        }
        if (perehodmodul2.r == false)
        {
            info.gameObject.SetActive(perehodmodul2.r);
        }
        if (perehodmodul3.r == false)
        {
            info.gameObject.SetActive(perehodmodul3.r);
        }
        if (perehodmodul4.r == false)
        {
            info.gameObject.SetActive(perehodmodul4.r);
        }
    }
    public void Show_Module()
    {
        SceneManager.LoadScene("Модули");
    }
    public void Show_Module1()
    {
        SceneManager.LoadScene("Задания модуля 1");
    }
    public void Show_Module2()
    {
        SceneManager.LoadScene("Задания модуля 2");
    }
    public void Show_Module3()
    {
        SceneManager.LoadScene("Задания модуля 3");
    }
    public void Show_Module4()
    {
        SceneManager.LoadScene("Задания модуля 4");
    }
    public void showhinfo()// инструкция (открытие)
    {
        info.gameObject.SetActive(true);
        k = true;
    }
    public void notshowhinfo()// инструкция (закрытие)
    {
        info.gameObject.SetActive(false);
        k = false;
    }
    
}
