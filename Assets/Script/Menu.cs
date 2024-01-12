using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{

    public Animator transition;
    public float transitionTime = 1f;


    public void Menus()
    {
        StartCoroutine(LoadLevel(0));
    }
    public void LevelSelection()
    {
        StartCoroutine(LoadLevel(1));
    }

    public void PuzzleLevel1()
    {
        StartCoroutine(LoadLevel(2));
    }
    public void obtainedGambus()
    {
        StartCoroutine(LoadLevel(3));
    }
    public void Level1()
    {
        StartCoroutine(LoadLevel(4));
    }
    public void LevelSelection2()
    {
        StartCoroutine(LoadLevel(5));
    }
    public void PuzzleLevel2()
    {
        StartCoroutine(LoadLevel(6));
    }
    public void obtainedGendang()
    {
        StartCoroutine(LoadLevel(7));
    }
    public void Level2()
    {
        StartCoroutine(LoadLevel(8));
    }
    public void LevelSelection3()
    {
        StartCoroutine(LoadLevel(9));
    }
    public void PuzzleLevel3()
    {
        StartCoroutine(LoadLevel(10));
    }
    public void obtainedAngklung()
    {
        StartCoroutine(LoadLevel(11));
    }
    public void Level3()
    {
        StartCoroutine(LoadLevel(12));
    }
    public void Credit()
    {
        StartCoroutine(LoadLevel(13));
    }

    IEnumerator LoadLevel(int levelIndex)
    {
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene(levelIndex);
    }

    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
