using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public float startTime = 60f; // The time at which the timer starts, in seconds. 
    private float timer; // The current time remaining on the timer.

    public TMP_Text timerText; // Reference to the TextMeshPro text component that displays the timer.

    void Start()
    {
        timer = startTime; // Initialize the timer to the starting time.
    }

    void Update()
    {
        if (timer > 0)
        {
            Debug.Log("Timer is running: " + timer); // Log the current timer value for debugging purposes.
            Debug.Log("Delta time: " + Time.deltaTime); // Log the delta time for debugging purposes.

            timer -= Time.deltaTime; // Decrease the timer by the time that has passed since the last frame.

            // convert 60 seconds to 0 and 1 seconds to 0.1, 30 seconds to 0.5, etc.
            float normalized = timer / startTime; // Calculate the normalized timer value (between 0 and 1).
            timerText.text = timer.ToString("F2"); // Update the timer text to show the current time remaining, formatted to 2 decimal places.
        }
        else
        {
            timer = 0; // Ensure the timer does not go below zero.
            timerText.text = "TIME'S UP!";
            timerText.color = Color.red;
            // Add game over logic here
            // FindObjectOfType<PlayerController>().GameOver();
        }
    }
}