using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonCloseCanvas : MonoBehaviour
{
    // The name of the scene you want to load
    public GameObject Canvas2;
    private Button button;

    void Start()
    {
        // Get the Button component from the GameObject this script is attached to
        button = GetComponent<Button>();
        if (Canvas2 != null)
        {
            Canvas2.SetActive(false);
        }
        // Add a listener to the button's onClick event and specify the method to call
        button.onClick.AddListener(CloseCanvas);
    }

    public void CloseCanvas()
    {
        // Load the specified scene when the button is clicked
        Canvas2.SetActive(false);
    }
}