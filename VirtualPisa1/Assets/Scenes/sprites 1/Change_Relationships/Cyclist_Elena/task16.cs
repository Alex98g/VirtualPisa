using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;
using TMPro;

public class task16 : MonoBehaviour
{
    int time_S, time_M, time_Ch;
    bool stop;
    public Text Answ; //текст ответа
    public GameObject ok; // "верно", "не верно"
    public Text prov; // значение 
    public GameObject stat; // кнопка статистики
    public GameObject original; // главная часть страницы
    public GameObject statistics; // страница статистики
    public GameObject hint1; // подсказка №1
    public GameObject hint2; // подсказка №2
    public GameObject hint3; // подсказка №2
    public GameObject podskaz2; // кнопка подсказки №2
    public GameObject podskaz3; // кнопка подсказки №3
    public GameObject podskaz1use; // кнопка испльзуемой подсказки №1
    public GameObject podskaz2use; // кнопка испльзуемой подсказки №2
    public GameObject podskaz3use; // кнопка испльзуемой подсказки №3
    int p1 = 0; // счётчик подсказки №1
    int p2 = 0; // счётчик подсказки №2
    int p3 = 0; // счётчик подсказки №3
    public TMP_Text pod1; // ввод счётчика подсказки №1
    public TMP_Text pod2; // ввод счётчика подсказки №2
    public TMP_Text pod3; // ввод счётчика подсказки №3
    int mistake; // счётчик неправильных ответов
    public TMP_Text texttime,textoshibka; // значение количества ошибок
    public GameObject usl1, usl2; //объекты задачи

    public Dropdown dropdown1, dropdown2;
    public Text TextCount;
    public InputField inputField;
    string countStr;
    float count;
    private void Start()
    {
        time_S = 0;
        stop = true;
        StartCoroutine("stopwatch");
        podskaz1use.gameObject.SetActive(false);
        podskaz2use.gameObject.SetActive(false);
        podskaz3use.gameObject.SetActive(false);
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
        if (Answ.text == "2")
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
        podskaz3.gameObject.SetActive(true);
        podskaz2use.gameObject.SetActive(true);
        p2++;
    }
    public void notshowhint2()// подсказка №2 (закрытие)
    {
        original.gameObject.SetActive(true);
        hint2.gameObject.SetActive(false);
    }
    public void showhint3()// подсказка №3 (открытие)
    {
        original.gameObject.SetActive(false);
        hint3.gameObject.SetActive(true);
        podskaz3use.gameObject.SetActive(true);
        p3++;
    }
    public void notshowhint3()// подсказка №3 (закрытие)
    {
        original.gameObject.SetActive(true);
        hint3.gameObject.SetActive(false);
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
        pod3.text = p3.ToString();
        textoshibka.text = mistake.ToString();
        texttime.text = time_Ch.ToString() + ':' + time_M.ToString() + ':' + time_S.ToString();
    }
    public void notshowstatistics() //закрытие статистики
    {
        original.gameObject.SetActive(true);
        statistics.gameObject.SetActive(false);
    }
    public void nextuslzad()//следующие объкты задачи
    {
        usl1.gameObject.SetActive(false);
        usl2.gameObject.SetActive(true);
    }
    public void backuslzad()//предыдущие объкты задачи
    {
        usl1.gameObject.SetActive(true);
        usl2.gameObject.SetActive(false);
    }
    public void ForDropdown()
    {

        for (int i = 0; i <= 2; i++)
            if ((dropdown1.value == i) && (dropdown2.value == i))
                TextCount.text = inputField.text;



        if (((dropdown1.value == 0) && (dropdown2.value == 1))
    || ((dropdown1.value == 1) && (dropdown2.value == 2)))
        {

            countStr = inputField.text;
            count = Convert.ToSingle(countStr) / 60; //перевод строки в число 
            countStr = count.ToString();
            TextCount.text = countStr;

        }
        if ((dropdown1.value == 0) && (dropdown2.value == 2))
        {

            countStr = inputField.text;
            count = Convert.ToSingle(countStr) / 360; //перевод строки в число 
            countStr = count.ToString();
            TextCount.text = countStr;

        }
        if ((dropdown1.value == 2) && (dropdown2.value == 0))
        {

            countStr = inputField.text;
            count = Convert.ToSingle(countStr) * 360; //перевод строки в число 
            countStr = count.ToString();
            TextCount.text = countStr;

        }
        if (((dropdown1.value == 2) && (dropdown2.value == 1))
            || ((dropdown1.value == 1) && (dropdown2.value == 0)))
        {

            countStr = inputField.text;
            count = Convert.ToSingle(countStr) * 60; //перевод строки в число 
            countStr = count.ToString();
            TextCount.text = countStr;
        }

    }
}
