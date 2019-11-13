using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;
public class TimerScript : MonoBehaviour
{
    public int timeLeft = 60; //Seconds Overall
    public Text countdown; //UI Text Object
    public GameObject scoreUI; //Main score UI
    public GameObject gameOverCanvas;
    void Start()
    {
        StartCoroutine("LoseTime");
        Time.timeScale = 1; //Just making sure that the timeScale is right
    }
    void Update()
    {
        countdown.text = ("" + timeLeft); //Showing the Score on the Canvas

        if (timeLeft <= 0)
        {
            Time.timeScale = 0.0f;
            timeLeft = 0; //This makes the timer 0 if it goes to a value less than 0.
            Lives.Die();
        }
    }
    //Simple Coroutine
    IEnumerator LoseTime()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            timeLeft--;
        }
    }

    public void AddToTime(int amount)
    {
        timeLeft += amount;
    }

    public void SubtractFromTime(int amount)
    {
        timeLeft -= amount;
    }

}