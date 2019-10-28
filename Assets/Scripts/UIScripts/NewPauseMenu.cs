﻿using UnityEngine;

public class NewPauseMenu : MonoBehaviour
{
    public GameObject pauseCanvas;

    public void Update()
    {
        if (Input.GetKeyDown("escape"))
        {
            Pause();
        }
    }

    public void Pause()
    {
            Time.timeScale = 0.0f;
            pauseCanvas.SetActive(true);
    }
}
