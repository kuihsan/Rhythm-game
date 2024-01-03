using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class CountDownTimer : MonoBehaviour
{
    public float timeLeft = 300f; // Set the initial time to 1000 seconds
    public Text timeText;
    private bool isPaused = false;

    // Start is called before the first frame update
    void Start()
    {
        // Optionally, you can start the countdown immediately by uncommenting the line below.
        // StartCoroutine(StartCountdown());
    }

    // Update is called once per frame
    void Update()
    {
        if (!isPaused)
        {
            if (timeLeft > 0)
            {
                timeLeft -= Time.deltaTime;
                DisplayTime();
                CheckAndChangeFont();
            }
            else
            {
                timeLeft = 0f;
                // Optionally, you can perform some action when the timer reaches 0.
                // For example, trigger the end of the game, show a message, etc.
                // You can add your logic here.
            }
        }
    }

    void DisplayTime()
    {
        float minutes = Mathf.FloorToInt(timeLeft / 60);
        float seconds = Mathf.FloorToInt(timeLeft % 60);

        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    void CheckAndChangeFont()
    {
        if (timeLeft <= 11f)
        {
            timeText.color = new Color(1.0f, 0.0f, 0.0f, 1.0f);
            StartCoroutine(FontChanger());
        }
    }

    IEnumerator FontChanger()
    {
        timeText.fontSize = 90;
        yield return new WaitForSeconds(0.3f);
        timeText.fontSize = 70;
        yield return new WaitForSeconds(0.3f);
    }
}