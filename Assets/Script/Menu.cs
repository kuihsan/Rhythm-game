using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void Menus()
    {
        SceneManager.LoadScene("Menu");
    }
    public void Level1()
    {
        SceneManager.LoadScene("Level1");
    }
    public void Level2()
    {
        SceneManager.LoadScene("Level2");
    }

    public void Level3()
    {
        SceneManager.LoadScene("Level3");
    }

    public void LevelSelection()
    {
        SceneManager.LoadScene("LevelSelection");
    }

    public void LevelSelection2()
    {
        SceneManager.LoadScene("LevelSelection2");
    }

    public void LevelSelection3()
    {
        SceneManager.LoadScene("LevelSelection3");
    }

    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}