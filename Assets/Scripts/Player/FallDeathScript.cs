using UnityEngine;

public class FallDeathScript : MonoBehaviour
{
    public GameObject gameOverCanvas;
    public void OnTriggerEnter(Collider other)
    {
        Lives.Die();
    }
}
