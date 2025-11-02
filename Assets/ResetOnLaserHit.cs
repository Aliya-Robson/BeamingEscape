using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetOnLaserHit : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // Check if the object we hit is a laser
        if (other.CompareTag("Laser"))
        {
            // Reload the current scene
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
