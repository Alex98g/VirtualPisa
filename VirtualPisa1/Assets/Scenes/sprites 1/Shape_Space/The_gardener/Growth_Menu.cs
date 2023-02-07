using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Growth_Menu : MonoBehaviour
{
    int time_S, time_M, time_Ch;
    bool stop;
    public GameObject ok; // "верно", "не верно"
    public Text prov; // значение
    public GameObject ar;//сцена с дополненной реальностью
    public GameObject stat; // кнопка статистики
    public GameObject original; // главная часть страницы
    public GameObject original1; // главная часть страницы AR
    public GameObject statistics; // страница статистики
    int p1 = 0; // счётчик подсказки №1
    int p2 = 0; // счётчик подсказки №2
    int p3 = 0; // счётчик подсказки №3
    int p4 = 0; // счётчик подсказки №4
    int p5 = 0; // счётчик подсказки №5
    int p6 = 0; // счётчик подсказки №6
    int p7 = 0; // счётчик подсказки №7
    int p8 = 0; // счётчик подсказки №8
    public TMP_Text pod1,pod2, pod3, pod4, pod5, pod6, pod7, pod8; // ввод счётчика подсказки №1
    int mistake; // счётчик неправильных ответов
    public TMP_Text texttime, textoshibka; // значение количества ошибок


    public Button btnY1A,btnY2A, btnN3A, btnN4A;
    public Button btnY1B, btnY2B, btnN3B, btnN4B;
    public Button btnY1C, btnY2C, btnN3C, btnN4C;
    public Button btnY1D, btnY2D, btnN3D, btnN4D;
    private bool YesA, NoA, YesB, NoB, YesC, NoC, YesD, NoD;
    //для подсказки
    public Button BtnHelpA, BtnHelpA1, BtnHelpB, BtnHelpB1, BtnHelpC, BtnHelpC1, BtnHelpD, BtnHelpD1, BtnHelp;
    public Button BtnHelpAuse, BtnHelpA1use, BtnHelpBuse, BtnHelpB1use, BtnHelpCuse, BtnHelpC1use, BtnHelpDuse, BtnHelpD1use, BtnHelpuse;
    public GameObject PanelA, PanelA1, PanelB, PanelB1, PanelC, PanelC1, PanelD, PanelD1;
    public bool HelpA=false, HelpA1=false, HelpB=false, HelpB1=false, HelpC=false, HelpC1=false, HelpD=false, Help=false;

    private void Start()
    {
        time_S = 00;
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
        public void showar() //открытие сцены AR
    {
        original.gameObject.SetActive(false);
        ar.gameObject.SetActive(true);
        //ChangeColorForYesA()
        btnY1A.gameObject.SetActive(true);
        btnY2A.gameObject.SetActive(false);
        btnN4A.gameObject.SetActive(false);
        btnN3A.gameObject.SetActive(true);
        //ChangeColorForYesB()
        btnY1B.gameObject.SetActive(true);
        btnY2B.gameObject.SetActive(false);
        btnN4B.gameObject.SetActive(false);
        btnN3B.gameObject.SetActive(true);
        //ChangeColorForYesC()
        btnY1C.gameObject.SetActive(true);
        btnY2C.gameObject.SetActive(false);
        btnN4C.gameObject.SetActive(false);
        btnN3C.gameObject.SetActive(true);
        //ChangeColorForYesD()
        btnY1D.gameObject.SetActive(true);
        btnY2D.gameObject.SetActive(false);
        btnN4D.gameObject.SetActive(false);
        btnN3D.gameObject.SetActive(true);
        YesA = false;
        NoA = false;
        YesB = false;
        NoB = false;
        YesC = false;
        NoC = false;
        YesD = false;
        NoD = false;
    }
    public void ChangeColorForYesA()
    {
        btnY1A.gameObject.SetActive(false);
        YesA = true;
        btnY2A.gameObject.SetActive(true);
        btnN4A.gameObject.SetActive(false);
        btnN3A.gameObject.SetActive(true);
        //return YesA;
    }
    public void ChangeColorForNoA()
    {
        btnN3A.gameObject.SetActive(false);
        NoA = false;
        btnN4A.gameObject.SetActive(true);
        btnY2A.gameObject.SetActive(false);
        btnY1A.gameObject.SetActive(true);
        //return NoA;
    }
    public void ChangeColorForYesB()
    {
        btnY1B.gameObject.SetActive(false);
        YesB = false;
        btnY2B.gameObject.SetActive(true);
        btnN4B.gameObject.SetActive(false);
        btnN3B.gameObject.SetActive(true);
        //return YesB;
    }
    public void ChangeColorForNoB()
    {
        btnN3B.gameObject.SetActive(false);
        btnN4B.gameObject.SetActive(true);
        NoB = true;
        btnY2B.gameObject.SetActive(false);
        btnY1B.gameObject.SetActive(true);
        //return NoB;
    }
    public void ChangeColorForYesC()
    {
        btnY1C.gameObject.SetActive(false);
        YesC = true;
        btnY2C.gameObject.SetActive(true);
        btnN4C.gameObject.SetActive(false);
        btnN3C.gameObject.SetActive(true);
        //return YesA;
    }
    public void ChangeColorForNoC()
    {
        btnN3C.gameObject.SetActive(false);
        NoC = false;
        btnN4C.gameObject.SetActive(true);
        btnY2C.gameObject.SetActive(false);
        btnY1C.gameObject.SetActive(true);
        //return NoA;
    }
    public void ChangeColorForYesD()
    {
        btnY1D.gameObject.SetActive(false);
        YesD = true;
        btnY2D.gameObject.SetActive(true);
        btnN4D.gameObject.SetActive(false);
        btnN3D.gameObject.SetActive(true);
        //return YesA;
    }
    public void ChangeColorForNoD()
    {
        btnN3D.gameObject.SetActive(false);
        NoD = false;
        btnN4D.gameObject.SetActive(true);
        btnY2D.gameObject.SetActive(false);
        btnY1D.gameObject.SetActive(true);
        //return NoA;
    }
    public void answer()
    {
        if ((YesA == true) && (NoB == true) && (YesC == true) && (YesD == true))
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
            //ChangeColorForYesA()
            btnY1A.gameObject.SetActive(true);
            btnY2A.gameObject.SetActive(false);
            btnN4A.gameObject.SetActive(false);
            btnN3A.gameObject.SetActive(true);
            //ChangeColorForYesB()
            btnY1B.gameObject.SetActive(true);
            btnY2B.gameObject.SetActive(false);
            btnN4B.gameObject.SetActive(false);
            btnN3B.gameObject.SetActive(true);
            //ChangeColorForYesC()
            btnY1C.gameObject.SetActive(true);
            btnY2C.gameObject.SetActive(false);
            btnN4C.gameObject.SetActive(false);
            btnN3C.gameObject.SetActive(true);
            //ChangeColorForYesD()
            btnY1D.gameObject.SetActive(true);
            btnY2D.gameObject.SetActive(false);
            btnN4D.gameObject.SetActive(false);
            btnN3D.gameObject.SetActive(true);
            YesA = false;
            NoA = false;
            YesB = false;
            NoB = false;
            YesC = false;
            NoC = false;
            YesD = false;
            NoD = false;
        }
    }
    public void BtnHelpBig()
    {
        BtnHelpD.gameObject.SetActive(true);
        BtnHelpC.gameObject.SetActive(true);
        BtnHelpB.gameObject.SetActive(true);
        BtnHelpA.gameObject.SetActive(true);
        BtnHelpuse.gameObject.SetActive(true);
    }
    public void BtnForHelpA()
    {
        PanelA.gameObject.SetActive(true);
        BtnHelpAuse.gameObject.SetActive(true);
        BtnHelpA1.gameObject.SetActive(true);
        p1++;
    }
    public void BtnForHelpA1()
    {
        PanelA.gameObject.SetActive(false);
        PanelA1.gameObject.SetActive(true);
        BtnHelpA1use.gameObject.SetActive(true);
        p2++;
    }

    public void BtnForHelpB()
    {
        BtnHelpB1.gameObject.SetActive(true);
        BtnHelpBuse.gameObject.SetActive(true);
        PanelB.gameObject.SetActive(true);
        p3++;
    }
    public void BtnForHelpB1()
    {
        PanelB.gameObject.SetActive(false);
        PanelB1.gameObject.SetActive(true);
        BtnHelpB1use.gameObject.SetActive(true);
        p4++;
    }

    public void BtnForHelpC()
    {
        BtnHelpC1.gameObject.SetActive(true);
        PanelC.gameObject.SetActive(true);
        BtnHelpCuse.gameObject.SetActive(true);
        p5++;
    }
    public void BtnForHelpC1()
    {
        PanelC.gameObject.SetActive(false);
        PanelC1.gameObject.SetActive(true);
        BtnHelpC1use.gameObject.SetActive(true);
        p6++;
    }
    public void BtnForHelpD()
    {
        PanelD.gameObject.SetActive(true);
        BtnHelpD1.gameObject.SetActive(true);
        BtnHelpDuse.gameObject.SetActive(true);
        p7++;
    }
    public void BtnForHelpD1()
    {
        PanelD.gameObject.SetActive(false);
        PanelD1.gameObject.SetActive(true);
        BtnHelpD1use.gameObject.SetActive(true);
        p8++;
    }
    public void ForBtnOKad()
    {
        PanelA.gameObject.SetActive(false);
        PanelA1.gameObject.SetActive(false);

        PanelB.gameObject.SetActive(false);
        PanelB1.gameObject.SetActive(false);

        PanelC.gameObject.SetActive(false);
        PanelC1.gameObject.SetActive(false);

        PanelD.gameObject.SetActive(false);
        PanelD1.gameObject.SetActive(false);
    }
    public void showstatistics()// Статистика
    {
        original1.gameObject.SetActive(false);
        statistics.gameObject.SetActive(true);
        pod1.text = p1.ToString();
        pod2.text = p2.ToString();
        pod3.text = p3.ToString();
        pod4.text = p4.ToString();
        pod5.text = p5.ToString();
        pod6.text = p6.ToString();
        pod7.text = p7.ToString();
        pod8.text = p8.ToString();
        textoshibka.text = mistake.ToString();
        texttime.text = time_Ch.ToString() + ':' + time_M.ToString() + ':' + time_S.ToString();
    }
    
    public void notshowar()//закрытие сцены AR
    {
        original.gameObject.SetActive(true);
        ar.gameObject.SetActive(false);
        BtnHelpAuse.gameObject.SetActive(false);
        BtnHelpA1use.gameObject.SetActive(false);
        BtnHelpBuse.gameObject.SetActive(false);
        BtnHelpB1use.gameObject.SetActive(false);
        BtnHelpCuse.gameObject.SetActive(false);
        BtnHelpC1use.gameObject.SetActive(false);
        BtnHelpDuse.gameObject.SetActive(false);
        BtnHelpD1use.gameObject.SetActive(false);
    }

    public void notshowver()// закрыть 
    {
        ok.gameObject.SetActive(false);
    }

}
