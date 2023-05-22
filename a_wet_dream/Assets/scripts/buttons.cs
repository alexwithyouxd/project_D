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
        //opens options menu or panel
    }

    public void extras()
    {
        //should open credits&extras scene
    }

    public void exit()
    {
        SceneManager.LoadScene("exit");
    }
}
