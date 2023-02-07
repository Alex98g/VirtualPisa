using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class task4 : MonoBehaviour
{
    int time_S, time_M, time_Ch;
    bool stop;
    public Text Answ1, Answ2, Answ3, Answ4;
    public GameObject ar;//сцена с дополненной реальностью
    public GameObject ok; // "верно", "не верно"
    public Text prov; // значение 
    public GameObject stat; // кнопка статистики
    public GameObject original; // главная часть страницы
    public GameObject statistics; // страница статистики
    public GameObject hint1; // подсказка №1
    public GameObject podskaz1; // кнопка подсказки №1
    public GameObject podskaz1use; // кнопка испльзуемой подсказки №1
    int p1 = 0; // счётчик подсказки №1
    public TMP_Text pod1; // ввод счётчика подсказки №1
    int mistake; // счётчик неправильных ответов
    public TMP_Text texttime, textoshibka; // значение количества ошибок
    public GameObject usl1, usl2; //объекты задачи
    private void Start()
    {
        time_S = 00;
        stop = true;
        StartCoroutine("stopwatch");
        podskaz1use.gameObject.SetActive(false);
    }
    IEnumerator stopwatch()
    {

        while (stop)
        {
            yield return new WaitForSeconds(1f);
            time_S++;
            if (time_S == 60)
            {
                time_S = 00;
                time_M++;

            }
            if (time_M == 60)
            {
                time_M = 00;
                time_Ch++;

            }
        }
    }
    
    public void answer()
    {
        if (((Answ1.text == "07:00") && (Answ2.text == "08:00") && (Answ3.text == "22:00") && (Answ4.text == "23:00")) ||
            ((Answ3.text == "7:30") && (Answ4.text == "9:00")) && (Answ1.text == "16:30") && (Answ2.text == "18:00"))
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
        textoshibka.text = mistake.ToString();
        texttime.text = time_Ch.ToString() + ':' + time_M.ToString() + ':' + time_S.ToString();
    }
    public void notshowstatistics()
    {
        original.gameObject.SetActive(true);
        statistics.gameObject.SetActive(false);
    }
    public void showhint1()// подсказка №1 (открытие)
    {
        original.gameObject.SetActive(false);
        hint1.gameObject.SetActive(true);
        podskaz1use.gameObject.SetActive(true);
        p1++;
    }
    public void notshowhint1()// подсказка №1 (закрытие)
    {
        original.gameObject.SetActive(true);
        hint1.gameObject.SetActive(false);
    }
    public void showar() //открытие сцены AR
    {
        original.gameObject.SetActive(false);
        ar.gameObject.SetActive(true);
        podskaz1.gameObject.SetActive(true);
    }
    public void notshowar()//закрытие сцены AR
    {
        original.gameObject.SetActive(true);
        ar.gameObject.SetActive(false);
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
}
