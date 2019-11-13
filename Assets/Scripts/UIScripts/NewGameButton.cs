using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewGameButton : MonoBehaviour
{
    public string titleScene;
    public PersistentData _data;
    public void OnClick()
    {
        Lives._data.lives = 5;
        SceneManager.LoadScene(titleScene);
        Time.timeScale = 1.0f;
    }
}
