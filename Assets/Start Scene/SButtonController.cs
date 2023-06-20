using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SButtonController : MonoBehaviour
{
    public GameObject[] buttons;
    public GameObject Optýons;
    public GameObject Credit;

    public void ChangeScene(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }
    public void Exit()
    {
        Application.Quit();
    }

    public void OpenSound(bool setting)
    {
        for (int i = 0; i < buttons.Length; i++)
        {
            buttons[i].SetActive(false);
        }
        if (setting == true)
        {
            Optýons.SetActive(true);
        }
        else
        {
            Credit.SetActive(true);
        }
    }

    public void CloseSound(bool setting)
    {
        for (int i = 0; i < buttons.Length; i++)
        {
            buttons[i].SetActive(true);
        }
        if (setting == true)
        {
            Optýons.SetActive(false);
        }
        else
        {
            Credit.SetActive(false);
        }

    }
}
