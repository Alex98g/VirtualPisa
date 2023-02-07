using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class perehodmodul4 : MonoBehaviour
{
    internal static bool r = true;
    public void Show_Z1()
    {
        SceneManager.LoadScene("Choose");
    }
    public void Show_Z2()
    {
        SceneManager.LoadScene("Cyclists");
    }
    public void Show_Z3()
    {
        SceneManager.LoadScene("Step_model");
    }
    public void Show_Z4()
    {
        SceneManager.LoadScene("Bookshelves");
    }
    public void Show_Z5()
    {
        SceneManager.LoadScene("Revolving_door");
    }
    public void Show_Z6()
    {
        SceneManager.LoadScene("Climbing_Mount_Fuji");
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
        SceneManager.LoadScene("Task_of_module_4");
    }
}
