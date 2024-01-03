using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonSceneLoader : MonoBehaviour
{
    // The name of the scene you want to load
    public string sceneToLoad;

    private Button button;

    void Start()
    {
        // Get the Button component from the GameObject this script is attached to
        button = GetComponent<Button>();

        // Add a listener to the button's onClick event and specify the method to call
        button.onClick.AddListener(LoadSceneOnClick);
    }

    public void LoadSceneOnClick()
    {
        // Load the specified scene when the button is clicked
        SceneManager.LoadScene(sceneToLoad);
    }
}