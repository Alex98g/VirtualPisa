using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class task23 : MonoBehaviour
{
    int time_S, time_M, time_Ch;
    bool stop;
    public GameObject ar;//сцена с дополненной реальностью
    public Text Answ; //текст ответа
    public GameObject ok; // "верно", "не верно"
    public Text prov; // значение 
    public GameObject stat; // кнопка статистики
    public GameObject original; // главная часть страницы
    public GameObject statistics; // страница статистики     
    int mistake; // счётчик неправильных ответов
    public Text texttime,textoshibka; // значение количества ошибок
    public GameObject Textpodskaz;
    public Toggle tog_people, tog_rotate;
    bool tog_people_active, tog_rotate_active;
    public GameObject People, ElevatorRotate, hints_people, hints_rotate;
    int count_activePeople, count_activeRotate;
    public Text text_peo, text_rot;
    private void Start()
    {
        Textpodskaz.SetActive(false);
        People.SetActive(false);
        hints_people.SetActive(false);
        hints_rotate.SetActive(false);
        count_activePeople = 0;
        count_activeRotate = 0;
        tog_people_active = false;
        tog_rotate_active = false;
        time_S = 0;
        stop = true;
        StartCoroutine("stopwatch");
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
    IEnumerator VisibleRotate()
    {
        int i = 0;
        hints_rotate.SetActive(true);
        do
        {
            ElevatorRotate.transform.eulerAngles = new Vector3(0, i, 0);
            yield return new WaitForSeconds(0.01f);
            i++;
        } while (i != 360);
        ElevatorRotate.transform.eulerAngles = new Vector3(0, 0, 0);
        hints_rotate.SetActive(false);
    }
    public void answer()
    {
        if (Answ.text == "720")
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
        text_peo.text = count_activePeople.ToString();
        text_rot.text = count_activeRotate.ToString();
        textoshibka.text = mistake.ToString();
        texttime.text = time_Ch.ToString() + ':' + time_M.ToString() + ':' + time_S.ToString();
    }
    public void showhint()// подсказка №1 (открытие)
    {
        Textpodskaz.gameObject.SetActive(true);
    }
    public void notshowstatistics() //закрытие статистики
    {
        original.gameObject.SetActive(true);
        statistics.gameObject.SetActive(false);
    }
    public void showar() //открытие сцены AR
    {
        original.gameObject.SetActive(false);
        ar.gameObject.SetActive(true);
    }
    public void notshowar()//закрытие сцены AR
    {
        original.gameObject.SetActive(true);
        ar.gameObject.SetActive(false);
    }
    public void tog_activePeople(bool is_On)
    {
        if (Textpodskaz.activeSelf == true)
        {
            if (is_On)
            {
                tog_people_active = true;
            }
            else
            {
                tog_people_active = false;
            }
        }
    }
    IEnumerator VisiblePeople()
    {
        People.SetActive(true);
        hints_people.SetActive(true);
        yield return new WaitForSeconds(6.6f);
        People.SetActive(false);
        hints_people.SetActive(false);
    }
    public void tog_activeRotate(bool is_On)
    {
        if (Textpodskaz.activeSelf == true)
        {
            if (is_On)
            {
                tog_rotate_active = true;
            }
            else
            {
                tog_rotate_active = false;
            }
        }
    }
    public void notshowhint()// подсказка №1 (закрытие)
    {
        Textpodskaz.SetActive(false);
        if (tog_people_active)
        {
            count_activePeople++;
            StartCoroutine("VisiblePeople");
            tog_people_active = false;
            tog_people.isOn = false;
        }
        if (tog_rotate_active)
        {
            count_activeRotate++;
            StartCoroutine("VisibleRotate");
            tog_rotate_active = false;
            tog_rotate.isOn = false;
        }

    }
}
