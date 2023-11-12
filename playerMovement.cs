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
        if (Input.GetKeyDown("w")){ //may switch from GetKeyDown to GetButtonDown(Jump) depending on if we change this in the input manager
            pb.velocity = new Vector2(p.velocity.x,15f);
        }
        if (Input.GetKeyDown("a")){ //may switch from GetKeyDown to GetButtonDown(Jump) depending on if we change this in the input manager
            pb.velocity = new Vector2(-7f,p.velocity.y);
        }
        if (Input.GetKeyDown("s")){ //may switch from GetKeyDown to GetButtonDown(Jump) depending on if we change this in the input manager
            pb.velocity = new Vector2(p.velocity.x,-15f);
        }
        if (Input.GetKeyDown("d")){ //may switch from GetKeyDown to GetButtonDown(Jump) depending on if we change this in the input manager
            pb.velocity = new Vector2(7f,p.velocity.y);
        }
    
    }
}