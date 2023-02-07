using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;
using TMPro;

public class Task_Door_manager : MonoBehaviour
{
    public GameObject DLGMHints, btnStatistics, DLGMStatistics, People, ElevatorRotate, hints_people, hints_rotate;
    public Text Placeholder;
    public Text Answer;
    int time, count_activePeople, count_activeRotate, count_input_error, time_start;
    public TMP_Text text_peo, text_rot, text_error, text_time;
    public Toggle tog_people, tog_rotate;
    public GameObject original; // главная часть страницы
    public GameObject ok; // "верно", "не верно"
    public GameObject ar;//сцена с дополненной реальностью
    public GameObject info;
    bool tog_people_active, tog_rotate_active;

    void Start()
    {
        DLGMHints.SetActive(false);
        DLGMStatistics.SetActive(false);
        btnStatistics.SetActive(false);
        People.SetActive(false);
        hints_people.SetActive(false);
        hints_rotate.SetActive(false);
        count_activePeople = 0;
        count_activeRotate = 0;
        count_input_error = 0;
        tog_people_active = false;
        tog_rotate_active = false;
        TimeSpan timeNow = DateTime.Now.TimeOfDay;        
        time_start = (int)((((timeNow.Hours*60)+timeNow.Minutes)*60) + timeNow.Seconds);
                
    }
    public void btn_Hints()
    {
        DLGMHints.SetActive(true);
    }
    public void tog_activePeople(bool is_On)
    {   
        if (DLGMHints.activeSelf == true)
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
        if (DLGMHints.activeSelf == true)
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

    public void btn_Back()
    {
        DLGMHints.SetActive(false);       
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
   
    
    public void btn_Verify()
    {
        if (Answer.text == "720")
        {
            ok.gameObject.SetActive(true);
            Placeholder.text = "Верно";
            Answer.text = "";
            btnStatistics.SetActive(true);
            TimeSpan timeNow = DateTime.Now.TimeOfDay;
            time = ((((timeNow.Hours * 60) + timeNow.Minutes) * 60) + timeNow.Seconds) - time_start;           
        }
        else
        {
            ok.gameObject.SetActive(true);
            Answer.text = "";
            Placeholder.text = "Не верно";
            count_input_error++;
        }
    }
    int temp;
    public void btn_Statistics()
    {
        text_peo.text = count_activePeople.ToString();
        text_rot.text = count_activeRotate.ToString();
        text_error.text = count_input_error.ToString();
        text_time.text = "";
        if (time % 3600  !=0)
        {
            temp = time / 3600;
            time = time - temp * 3600;
            text_time.text = text_time.text + temp + ":";
        }
        else
        {
            text_time.text = text_time.text + "00:";
        }
        if (time % 60 != 0)
        {
            temp = time / 60;
            time = time - temp * 60;
            text_time.text = text_time.text + temp + ":";
        }
        else
        {
            text_time.text = text_time.text + "00:";
        }
        text_time.text = text_time.text + time;
        DLGMStatistics.SetActive(true);
    }
    public void notshowver()// закрыть 
    {
        original.gameObject.SetActive(true);
        ok.gameObject.SetActive(false);
    }
    public void showhint()// подсказка №1 (открытие)
    {
        DLGMHints.gameObject.SetActive(true);
    }
    public void notshowstatistics() //закрытие статистики
    {
        original.gameObject.SetActive(true);
        DLGMStatistics.gameObject.SetActive(false);
    }
    public void showar() //открытие сцены AR
    {
        original.gameObject.SetActive(false);
        ar.gameObject.SetActive(true);
        info.gameObject.SetActive(true);
    }
    public void notshowar()//закрытие сцены AR
    {
        original.gameObject.SetActive(true);
        ar.gameObject.SetActive(false);
    }
    public void notinfo()//закрытие информации
    {
        info.gameObject.SetActive(false);
    }
}
