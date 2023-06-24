using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stats : MonoBehaviour
{
    public GameObject star1, star2, star3;
    public Text currentTimeText;
    public Text finishText;
    public static int stars = 1;
    public static float devTime = 30f;
    private static bool computed = false;

    public void Start()
    {
        star1.SetActive(false);
        star2.SetActive(false);
        star3.SetActive(false);
    }
    void Update()
    {
        Time();
        showStars();
        Debug.Log(stars);
    }

    public void Time()
    {
        float currentTime = Stopwatch.currentTime;
        currentTimeText.text = currentTime.ToString();
        //finishText.text = "Final Time: " + currentTime.text;
        //Debug.Log(Stopwatch.currentTime);
    }

    public static void numOfStars()
    {
        if (LevelScore.enemiesWiped == LevelScore.totalEnemies)
        {
            stars++;
        }
        if (Stopwatch.currentTime < devTime)
        {
            stars++;
        }
    }

    public void showStars()
    {
        if (!computed)
        {
            numOfStars();
        }

        star1.SetActive(true);

        if (stars == 2)
        {
            star2.SetActive(true);
        }
        else if (stars == 3)
        {
            star2.SetActive(true);
            star3.SetActive(true);
        }
        computed = true;
    }
}
