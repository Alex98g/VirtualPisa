using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class perehodmodul1 : MonoBehaviour
{

    internal static bool r = true;
    public void Show_Z1()
    {
        SceneManager.LoadScene("Cubes");
    }
    public void Show_Z2()
    {
        SceneManager.LoadScene("The_gardener");
    }
    public void Show_Z3()
    {
        SceneManager.LoadScene("Cubes1");
    }
    public void Show_Z4()
    {
        SceneManager.LoadScene("View_of_the_tower");
    }
    public void Show_Z5()
    {
        SceneManager.LoadScene("Buying_an_apartment");
    }
    public void Show_Z6()
    {
        SceneManager.LoadScene("Ladder");
    }
    public void Show_Z7()
    {
        SceneManager.LoadScene("Sailing_ships");
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
        SceneManager.LoadScene("Task_of_module_1");
    }
}