using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    public void ButtonMoveScene(string MainMenu)
    {
        SceneManager.LoadScene(MainMenu);
    }
    public void Level1()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void KeluarGame()
    {
        Application.Quit();
        Debug.Log("Exit");
    }
}
