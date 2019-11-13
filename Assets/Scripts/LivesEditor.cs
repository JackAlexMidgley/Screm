using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LivesEditor : MonoBehaviour
{
    public int numberOfLives = 5; //Overall number of lives, can be changed in Unity
    public Text lifeCount; //UI Object showing  number of lives
    public GameObject scoreUI; //Main score UI
    public GameObject gameOverCanvas;
    //    public GameObject player;


    // Start is called before the first frame update
    void Start()
    {
        lifeCount.text = "" + numberOfLives;

        Lives.numberOfLives = numberOfLives;
        Lives.lifeCount = lifeCount;
        Lives.scoreUI = scoreUI;
        Lives.gameOverCanvas = gameOverCanvas;
//        Lives.player = player;
    }
}
