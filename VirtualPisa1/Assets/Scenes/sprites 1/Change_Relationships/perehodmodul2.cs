using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class perehodmodul2 : MonoBehaviour
{
    internal static bool r = true;
    public void Show_Z1()
    {
        SceneManager.LoadScene("Communication_on_the_Internet");
    }
    public void Show_Z2()
    {
        SceneManager.LoadScene("Communication_on_the_Internet2");
    }
    public void Show_Z3()
    {
        SceneManager.LoadScene("Cyclist_Elena");
    }
    public void Show_Z4()
    {
        SceneManager.LoadScene("Drop_rate");
    }
    public void Show_Z5()
    {
        SceneManager.LoadScene("Cyclist_Elena1");
    }
    public void Show_Z6()
    {
        SceneManager.LoadScene("Apple_trees");
    }
    public void Show_Module()
    {
        SceneManager.LoadScene("modules");
        r = false;
    }
    public void Show_MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void Show_zadmodule()
    {
        SceneManager.LoadScene("Task_of_module_2");
    }
}
