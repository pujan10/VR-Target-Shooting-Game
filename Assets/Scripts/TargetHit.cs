using UnityEngine;

public class TargetHit : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))  // Ensure the bullet has the "Bullet" tag
        {
            // Destroy the target when hit
            Destroy(gameObject);
        }
    }
}
