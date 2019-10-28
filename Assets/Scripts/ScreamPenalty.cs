using UnityEngine;

public class ScreamPenalty : Health

{
    public int penalty;

    public override void Die()
    {
        GameObject.Find("EventSystem").GetComponent<TimerScript>().SubtractFromTime(penalty);
        base.Die();
    }
}
