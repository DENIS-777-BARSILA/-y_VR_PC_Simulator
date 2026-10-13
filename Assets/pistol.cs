using UnityEngine;

public class FireBullet : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform firePoint;
    public float bulletSpeed = 20f;
    public float bulletLifetime = 5f; // seconds before bullet is destroyed

    public AudioClip clip;
    private AudioSource source;

    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    public void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody rb = bullet.GetComponent<Rigidbody>();

        source.PlayOneShot(clip);

        if (rb != null)
        {
            rb.linearVelocity = firePoint.forward * bulletSpeed;
        }

        // Destroy the bullet after a set time
        Destroy(bullet, bulletLifetime);
    }
}