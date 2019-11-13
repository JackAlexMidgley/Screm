using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeedPickup : Pickup
{
    public AudioSource crunchSource;
    public AudioClip cruchSoundClip;

    private void OnTriggerEnter(UnityEngine.Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            crunchSource.PlayOneShot(cruchSoundClip);
            GameObject.Find("ScoreManager").GetComponent<ScoreManager>().AddToScore(scoreValue);
            Destroy(gameObject);
        }
        else
        {
            return;
        }
    }
}
