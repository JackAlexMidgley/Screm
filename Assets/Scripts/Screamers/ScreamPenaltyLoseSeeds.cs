using UnityEngine;

public class ScreamPenaltyLoseSeeds : Health

{

    public override void Die()
    {
        GameObject.Find("ScoreManager").GetComponent<ScoreManager>().ResetScore();
        base.Die();
    }
}
