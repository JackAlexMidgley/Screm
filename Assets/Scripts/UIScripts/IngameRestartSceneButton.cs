using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IngameRestartSceneButton : MonoBehaviour
{
    public string sceneName;
    public GameObject pauseCanvas;
    public PersistentData _data;

    public void OnClick()
    {
        pauseCanvas.SetActive(false);
        Lives.Die();
        Time.timeScale = 1.0f;
    }
}
