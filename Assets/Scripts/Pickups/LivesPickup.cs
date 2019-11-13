using UnityEngine;

public class LivesPickup : MonoBehaviour
{
    public PersistentData _data;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
 //           Lives.AddToLives(1);
            Destroy(gameObject);
        }
        else
        {
            return;
        }
    }
}
