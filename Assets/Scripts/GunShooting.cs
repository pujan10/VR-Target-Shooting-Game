using UnityEngine;

public class GunShooting : MonoBehaviour
{
    public GameObject bulletPrefab;      // Reference to the bullet prefab
    public Transform shootingPoint;      // The point where the bullet spawns
    public float shootForce = 500f;      // Force applied to the bullet

    void Update()
    {
        // Check for player input to shoot (you can replace "Fire1" with your desired input)
        if (Input.GetMouseButtonDown(0))  // Left mouse button for shooting
        {
            Shoot();
        }
    }

    void Shoot()
    {
        // Instantiate the bullet at the shooting point
        GameObject bullet = Instantiate(bulletPrefab, shootingPoint.position, shootingPoint.rotation);

        // Get the Rigidbody of the bullet and apply force to shoot it
        Rigidbody rb = bullet.GetComponent<Rigidbody>();
        rb.AddForce(shootingPoint.forward * shootForce);

        // Optional: Destroy the bullet after a few seconds to prevent clutter
        Destroy(bullet, 5f);
    }
}
