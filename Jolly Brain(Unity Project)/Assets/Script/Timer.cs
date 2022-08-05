using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [Header("CountdownTimer")]
    public Text timerText;
    public float startingTime = 180f;
    float currentTime = 0f;

    [Header("Game Over")]
    public GameObject gameoverScreen;
    public GameObject button;

    void Start()
    {
        currentTime = startingTime;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        timerText.text = "TIMER: " + currentTime.ToString("0");

        if (currentTime <= 0)
        {
            currentTime = 0;
            gameoverScreen.gameObject.SetActive(true);
            button.gameObject.SetActive(false);
            Time.timeScale = 0f;
        }
    }
}
