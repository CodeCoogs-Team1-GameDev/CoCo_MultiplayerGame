using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//class for player movement
public class PlayerMovement : MonoBehavior{
    private PlayerBody pb;
    private void start(){
        pb = GetComponet<PlayerBody>();


    }

    private void Update(){
        //float dirX = Input.GetAxis("Horizontal");
        //rb.velocity = new Vector2(dirX * 7f, p.velocity.y);
        if (Input.GetKeyDown("w")){ //may switch from GetKeyDown to GetButtonDown() depending on if we change this in the input manager
            pb.velocity = new Vector2(p.velocity.x,15f);
        }
        if (Input.GetKeyDown("a")){ //may switch from GetKeyDown to GetButtonDown() depending on if we change this in the input manager
            pb.velocity = new Vector2(-7f,p.velocity.y);
        }
        if (Input.GetKeyDown("s")){ //may switch from GetKeyDown to GetButtonDown() depending on if we change this in the input manager
            pb.velocity = new Vector2(p.velocity.x,-15f);
        }
        if (Input.GetKeyDown("d")){ //may switch from GetKeyDown to GetButtonDown() depending on if we change this in the input manager
            pb.velocity = new Vector2(7f,p.velocity.y);
        }
        if (Input.GetKeyDown("space")){ //may switch from GetKeyDown to GetButtonDown() depending on if we change this in the input manager
            
        }
    }
    public class PlayerController : MonoBehaviour
{
    public float attackRange = 1.0f;
    public float attackCooldown = 1.0f;
    private float nextAttackTime = 0f;
    private void Update(){
    if (Input.GetButtonDown("space") && Time.time >= nextAttackTime){ //or Fire1 instead of space
        Attack();
        nextAttackTime = Time.time + 1f / attackCooldown;
    }
}

    private void Attack(){
        // Perform attack logic here, e.g., play animation, deal damage, etc.
        Debug.Log("Player hit!");

        // Check for enemies within the attack range and perform actions if needed
        Collider[] hitEnemies = Physics.OverlapSphere(transform.position, attackRange);

        foreach (Collider enemy in hitEnemies){
            // Check if the collider belongs to an enemy
            if (enemy.CompareTag("Enemy")){
                // Deal damage to the enemy or perform other actions
                enemy.GetComponent<EnemyScript>().TakeDamage(10); // Example: Assuming enemies have a TakeDamage method
            }
        }
    }

}
