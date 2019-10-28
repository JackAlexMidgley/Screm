using UnityEngine;

public class FallDeathScript : MonoBehaviour
{
    public GameObject gameOverCanvas;
    public void OnTriggerEnter(Collider other)
    {
        Time.timeScale = 0.0f;
        gameOverCanvas.SetActive(true);
    }
}
