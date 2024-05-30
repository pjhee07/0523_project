using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("SelectStage");
    }
    public void BacktoStart()
    {
        SceneManager.LoadScene("Start");
    }
    public void OneStage()
    {
        SceneManager.LoadScene("Game1");
    }
    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("exit");
    }

}
