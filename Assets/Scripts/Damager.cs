using UnityEngine;

public class Damager : MonoBehaviour
{
    public int damage;

    public string targetTag = "";

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == targetTag)
        {
            other.gameObject.GetComponent<Health>().TakeDamage(damage);
        }
    }
}
