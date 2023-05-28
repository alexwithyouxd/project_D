using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttons : MonoBehaviour
{
    //sare buttons ke liye script

    public void Continue()
    {
        //continue function
    }

    public void New_game()
    {
        //should play cutscene first then gameplay
        SceneManager.LoadScene("cutscene");
    }

    public void Options()
    {
        SceneManager.LoadScene("options");

    }

    public void extras()
    {
        SceneManager.LoadScene("extras");

    }

    public void exit()
    {
        SceneManager.LoadScene("exit");
    }

    public void mainmenu()
    {
        SceneManager.LoadScene("main menu");

    }
}
