/*// PlayerController.cs

using UnityEngine;

public class PlayerController : MonoBehaviour
{
    void Update()
    {
        if (!isLocalPlayer) return;

        // Handle player input and movement
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(horizontal, 0, vertical) * Time.deltaTime * speed);

        // Check for actions (e.g., shooting) and use [Command] to execute on the server
        if (Input.GetButtonDown("Fire1"))
        {
            CmdFire();
        }
    }

    //[Command]
    void CmdFire()
    {
        // Spawn bullets or perform shooting logic on the server
        // Then use [ClientRpc] to notify clients about the action
        RpcSpawnBullet();
    }

    //[ClientRpc]
    void RpcSpawnBullet()
    {
        // Spawn bullets on all clients
    }
    
    private float baseStrength = 1f;
    private float baseSpeed = 1f;
    private float currentStrength;

    // Other player controller code...

    public void ApplyStrengthPowerUp(float strengthMultiplier)
    {
        // Apply the strength power-up
        currentStrength = baseStrength * strengthMultiplier;
        
        // You might want to play a sound or show a visual effect here
    }
}
*/
