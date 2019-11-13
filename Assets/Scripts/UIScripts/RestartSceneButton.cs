using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartSceneButton : MonoBehaviour
{
    public GameObject pauseCanvas;
    public string sceneName;
    public PersistentData _data;

    public void OnClick()
    {
        pauseCanvas.SetActive(false);
        Lives._data.lives = 5;
        SceneManager.LoadScene(sceneName);
        Time.timeScale = 1.0f;
    }
}
