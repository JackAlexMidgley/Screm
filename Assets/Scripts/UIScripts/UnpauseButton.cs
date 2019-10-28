using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnpauseButton : MonoBehaviour
{
    public GameObject pauseCanvas;

    public void OnClick()
    {
        Time.timeScale = 1.0f;
        pauseCanvas.SetActive(false);
    }
}
