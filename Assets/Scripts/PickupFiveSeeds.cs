using UnityEngine;

public class PickupFiveSeeds : Pickup
{
    // Start is called before the first frame update

    public int timeValue;

    private void OnTriggerEnter(UnityEngine.Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            GameObject.Find("ScoreManager").GetComponent<ScoreManager>().AddToScore(scoreValue);
            GameObject.Find("EventSystem").GetComponent<TimerScript>().AddToTime(timeValue);
            Destroy(gameObject);

        }
        else
        {
            return;
        }
    }
}
