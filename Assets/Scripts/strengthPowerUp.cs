/* // StrengthPowerUp.cs

using UnityEngine;

public class StrengthPowerUp : MonoBehaviour
{
    public float strengthMultiplier = 4f; // Adjust this value based on your requirements

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            ApplyPowerUp(other.gameObject);
            Destroy(gameObject); // Destroy the power-up object once collected
        }
    }

    void ApplyPowerUp(GameObject player)
    {
        // Apply strength power-up to the player
        PlayerController playerController = player.GetComponent<PlayerController>();

        if (playerController != null)
        {
            playerController.ApplyStrengthPowerUp(strengthMultiplier);
        }
    }
}
*/