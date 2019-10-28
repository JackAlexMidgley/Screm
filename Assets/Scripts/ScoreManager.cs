using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    private int score = 0;

    public Text scoreDisplay;

    // Start is called before the first frame update
    void Start()
    {
        ResetScore();
        //scoreDisplay = GetComponent<Text>();
        scoreDisplay.text = "" + score;
      
    }

    // Update is called once per frame
    void Update()
    {
        scoreDisplay.text = "" + score.ToString();
 
    }

    public void AddToScore (int amount)
    {
        score += amount;
    }

    public void ResetScore ()
    {
        score = 0;
    }
}
