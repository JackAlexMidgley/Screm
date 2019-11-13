using UnityEngine;

public class ScreamPenalty : Health

{
    public int penalty;

    public override void Die()
    {
        GameObject.Find("ScoreManager").GetComponent<TimerScript>().SubtractFromTime(penalty);
        base.Die();
    }
}
