using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public TMP_Text timerTxt;
    float totalTime = 300f; //5 minutes

    private void Update()
    {
        totalTime -= Time.deltaTime;
        UpdateLevelTimer(totalTime);
    }

    void UpdateLevelTimer(float totalSeconds)
    {
        int minutes = Mathf.FloorToInt(totalSeconds / 60f);
        int seconds = Mathf.RoundToInt(totalSeconds % 60f);

        string formatedSeconds = seconds.ToString();

        if (seconds == 60)
        {
            seconds = 0;
            minutes += 1;
        }

        timerTxt.text = minutes.ToString("00") + ":" + seconds.ToString("00");

        if (seconds == 0f && minutes == 0f)
        {
            ReturnMenu();
        }
    }

    void ReturnMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

}
