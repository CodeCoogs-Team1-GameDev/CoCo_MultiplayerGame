// PlayerController.cs

using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float baseStrength = 1f;
    private float currentStrength;

    // Other player controller code...

    public void ApplyStrengthPowerUp(float strengthMultiplier)
    {
        // Apply the strength power-up
        currentStrength = baseStrength * strengthMultiplier;
        
        // You might want to play a sound or show a visual effect here
    }
}
