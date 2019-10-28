using UnityEngine;

public class ScreamReward : Health

{
    public GameObject reward;

    public override void Die()
    {
        reward.SetActive(true);
        base.Die();
    }
}
