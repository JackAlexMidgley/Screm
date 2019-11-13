using UnityEngine;

public class PickupFiveSeeds : MonoBehaviour
{
    public int scoreValue;
    public int timeValue;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            GameObject.Find("ScoreManager").GetComponent<ScoreManager>().AddToScore(scoreValue);
            GameObject.Find("ScoreManager").GetComponent<TimerScript>().AddToTime(timeValue);
            Destroy(gameObject);
        }
        else
        {
            return;
        }
    }
}
