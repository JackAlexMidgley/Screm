using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public static class Lives
{
    public static PersistentData _data;
    
    public static Text lifeCount; //UI Object showing  number of lives
    public static GameObject scoreUI; //Main score UI
    public static GameObject gameOverCanvas;
//    public static GameObject player;


    public static void Die()
    {

        if (_data.lives >= 1)
        {
            AddToLives(-1);
            SceneManager.LoadScene("ScremLevel01"); //A crude way of restarting the scene. ATM the life loss doesn't carry over.
        }

        else
        {
            Time.timeScale = 0.0f;
            scoreUI.SetActive(false);
            gameOverCanvas.SetActive(true);
        }
    }

    public static void AddToLives(int amount)
    {
        _data.lives += amount;
    }
}
