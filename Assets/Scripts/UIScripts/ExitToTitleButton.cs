using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ExitToTitleButton : MonoBehaviour
{
    public string titleName;

    public void OnClick()
    {
        SceneManager.LoadScene(titleName);
        Time.timeScale = 1.0f;
    }
}
