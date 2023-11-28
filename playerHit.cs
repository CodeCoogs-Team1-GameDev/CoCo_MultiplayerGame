using UnityEngine;

public class EnemyScript : MonoBehaviour{
    public int damage = 10;

    void OnTriggerEnter(Collider other){
        if (other.CompareTag("Player"))
        {
            // Assuming the player has a PlayerHealth component
            other.GetComponent<PlayerHealth>().TakeDamage(damage);
        }
    }
    public class PlayerHealth : MonoBehaviour{
    public int maxHealth = 100;
    private int currentHealth;

    private void Start(){
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damage){
        currentHealth -= damage;

        // Add any additional logic for when the player takes damage, e.g., play a hurt animation, show a UI health bar update, etc.

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    private void Die(){
        // Add any logic for player death, e.g., play a death animation, respawn the player, etc.
        Debug.Log("Player died!");
        // You may want to disable the player GameObject or trigger a game over state here.
    }
}

