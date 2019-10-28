using UnityEngine;

public class Health : MonoBehaviour
{
    public AudioClip DeathSound;
    public AudioClip ShooSound;
    public AudioSource CharacterSource;

    [SerializeField]
    protected int health;

    [SerializeField]
    protected int maxHealth;

    public void Start()
    {
        CharacterSource = GetComponent<AudioSource>();
    }

    public void TakeDamage (int amount)
    {
        health -= amount;

        health = Mathf.Clamp(health, 0, maxHealth);
        if (health <=0)
        {
            Die();
        }
    }

    public void AddHealth (int amount)
    {
        health += amount;

        health = Mathf.Clamp(health, 0, maxHealth);
    }

    public virtual void Die()
    {
        CharacterSource.PlayOneShot(DeathSound);
        Destroy(gameObject);
    }

    public void MultiplyHealth(int amount)
    {
        health *= amount;
    }
}
