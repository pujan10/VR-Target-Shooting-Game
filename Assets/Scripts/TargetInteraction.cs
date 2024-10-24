using UnityEngine;
using UnityEngine.UI;  // Import UI namespace for working with Text

public class TargetInteraction : MonoBehaviour
{
    public AudioSource hitSound;     
    public static int score = 0;    
    public int pointsPerHit = 10;     

    public Text scoreText;             

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            // Play the hit sound (if assigned)
            if (hitSound != null)
            {
                hitSound.Play();
            }

            // Increment the score
            score += pointsPerHit;

            // Update the UI Text with the new score
            if (scoreText != null)
            {
                scoreText.text = "Score: " + score;
            }

        }
    }
}
