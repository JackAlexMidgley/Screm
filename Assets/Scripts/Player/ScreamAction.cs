using UnityEngine;

public class ScreamAction : MonoBehaviour
{

    public Transform muzzlePoint;
    public GameObject projectile;

    public AudioClip ScreamSound;
    public AudioSource ScreamSource;
    bool playAudio = false;

    [Range(0.1f, 300f)]
    public float projectilesPerSecond;
    private float projectileDelay;
    public float projectileTimer;

    void Start()
    {
        projectileDelay = 1.0f / projectilesPerSecond;
        ScreamSource = GetComponent<AudioSource>();
    }

    public void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            Fire();
        }
        else if (projectileTimer > 0)
        {
            projectileTimer = Mathf.Clamp(projectileTimer - Time.deltaTime, 0.0f, projectileDelay);
        }
    }

    private void Fire()
    {
        projectileTimer -= Time.deltaTime;

        while (projectileTimer <= 0)
        {
            Instantiate(projectile, muzzlePoint.transform.position, muzzlePoint.transform.rotation);

            projectileTimer += projectileDelay;
            ScreamSource.PlayOneShot(ScreamSound);
        }
    }

}
