using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;
using TMPro;

public class task7 : MonoBehaviour
{
    // Update is called once per frame
    int time_S, time_M, time_Ch;
    bool stop;
    public Text Answ;
    public GameObject ok; // "верно", "не верно"
    public Text prov; // значение 
    public GameObject stat; // кнопка статистики
    public GameObject original; // главная часть страницы
    public GameObject statistics; // страница статистики
    public GameObject hint1; // подсказка №1
    public GameObject hint2; // подсказка №1
    public GameObject podskaz2; // кнопка подсказки №2
    public GameObject podskaz1use; // кнопка испльзуемой подсказки №1
    public GameObject podskaz2use; // кнопка испльзуемой подсказки №2
    int p1 = 0; // счётчик подсказки №1
    int p2 = 0; // счётчик подсказки №2
    public TMP_Text pod1; // ввод счётчика подсказки №1
    public TMP_Text pod2; // ввод счётчика подсказки №2
    int mistake; // счётчик неправильных ответов
    public TMP_Text texttime, textoshibka; // значение количества времени и ошибок
    private void Start()
    {
        time_S = 0;
        stop = true;
        StartCoroutine("stopwatch");
        podskaz1use.gameObject.SetActive(false);
        podskaz2use.gameObject.SetActive(false);
    }
    IEnumerator stopwatch()
    {
        while (stop)
        {
            yield return new WaitForSeconds(1f);
            time_S++;
            if (time_S == 60)
            {
                time_S = 0;
                time_M++;
            }
            if (time_M == 60)
            {
                time_M = 0;
                time_Ch++;
            }
        }
    }
    public void answer()
    {
        if (Answ.text == "6")
        {
            stop = false;
            ok.gameObject.SetActive(true);
            prov.text = "Верно";
            stat.gameObject.SetActive(true);
        }
        else
        {
            mistake++;
            ok.gameObject.SetActive(true);
            prov.text = "Не верно";
            stat.gameObject.SetActive(false);
        }
    }
    public void showhint1()// подсказка №1 (открытие)
    {
        original.gameObject.SetActive(false);
        hint1.gameObject.SetActive(true);
        podskaz2.gameObject.SetActive(true);
        podskaz1use.gameObject.SetActive(true);
        p1++;
    }
    public void notshowhint1()// подсказка №1 (закрытие)
    {
        original.gameObject.SetActive(true);
        hint1.gameObject.SetActive(false);
    }
    public void showhint2()// подсказка №2 (открытие)
    {
        original.gameObject.SetActive(false);
        hint2.gameObject.SetActive(true);
        podskaz2use.gameObject.SetActive(true);
        p2++;
    }
    public void notshowhint2()// подсказка №2 (закрытие)
    {
        original.gameObject.SetActive(true);
        hint2.gameObject.SetActive(false);
    }
    public void notshowver()// закрыть 
    {
        original.gameObject.SetActive(true);
        ok.gameObject.SetActive(false);
    }
    public void showstatistics()// Статистика
    {
        original.gameObject.SetActive(false);
        statistics.gameObject.SetActive(true);
        pod1.text = p1.ToString();
        pod2.text = p2.ToString();
        textoshibka.text = mistake.ToString();
        texttime.text = time_Ch.ToString() + ':' + time_M.ToString() + ':' + time_S.ToString();
    }
    public void notshowstatistics()
    {
        original.gameObject.SetActive(true);
        statistics.gameObject.SetActive(false);
    }

}
