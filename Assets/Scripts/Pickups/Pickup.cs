﻿using UnityEngine;

public class Pickup : MonoBehaviour
{
    public int scoreValue;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            GameObject.Find("ScoreManager").GetComponent<ScoreManager>().AddToScore(scoreValue);
            Destroy(gameObject);
        }
        else
        {
            return;
        }
    }
}
