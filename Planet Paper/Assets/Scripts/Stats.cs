using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stats : LevelScore
{
    public GameObject star1, star2, star3;
    public Text currentTimeText;
    public Text finishText;
    public static int stars = 1;
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
        //Debug.Log(stars);
        Debug.Log("Enemies Wiped: " + enemiesWiped);
        Debug.Log("Total Enemies: " + totalEnemies);
    }

    public void Time()
    {
        float currentTime = Stopwatch.currentTime;
        currentTimeText.text = currentTime.ToString();
        //finishText.text = "Final Time: " + currentTime.text;
        //Debug.Log(Stopwatch.currentTime);
    }

    public void numOfStars()
    {
        if (enemiesWiped == totalEnemies)
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
