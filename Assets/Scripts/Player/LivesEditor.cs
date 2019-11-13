using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LivesEditor : MonoBehaviour
{
    public PersistentData _data;
   
    public Text lifeCount; //UI Object showing  number of lives
    public GameObject scoreUI; //Main score UI
    public GameObject gameOverCanvas;
    //    public GameObject player;


    // Start is called before the first frame update
    void Start()
    {
        lifeCount.text = "" +_data.lives;
        Lives._data = _data;
        Lives.lifeCount = lifeCount;
        Lives.scoreUI = scoreUI;
        Lives.gameOverCanvas = gameOverCanvas;
//        Lives.player = player;
    }
}
