using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class perehodmodul3 : MonoBehaviour
{
    internal static bool r = true;
    public void Show_Z1()
    {
        SceneManager.LoadScene("Geography_tests");
    }
    public void Show_Z2()
    {
        SceneManager.LoadScene("Colored_candies");
    }
    public void Show_Z3()
    {
        SceneManager.LoadScene("Sale_of_music_discs");
    }
    public void Show_Z4()
    {
        SceneManager.LoadScene("Growth");
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
        SceneManager.LoadScene("Task_of_module_3");
    }
}
