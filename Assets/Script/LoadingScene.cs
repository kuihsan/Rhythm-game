using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;
using System.Threading.Tasks;

public class LoadingScene : MonoBehaviour
{
    public GameObject LoadingScreen;
    public Image LoadingBarFill;

    public void LoadScene (int sceneId)
    {

        StartCoroutine(LoadSceneAsync(sceneId));
    }

IEnumerator LoadSceneAsync(int SceneId)
    {       
        AsyncOperation operation = SceneManager.LoadSceneAsync(SceneId);
        LoadingScreen.SetActive(true);

        while (!operation.isDone) 
        {
            float progressValue = Mathf.Clamp01(operation.progress/0.9f);
            LoadingBarFill.fillAmount = progressValue;
            yield return null;
        }
    }
}
