using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoading : MonoBehaviour
{
    public void LoadingScene(int number)
    {
        SceneManager.LoadScene(number);
    }
    public void GameExit()
    {
        Application.Quit();
    }
}
