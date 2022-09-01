
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{ // tags can be used to group objects

    public player movement;
    public  AudioSource explosion;
    
    
    void OnCollisionEnter(Collision collideinfo)
    {
        explosion.GetComponent<AudioSource>();
        
        if (collideinfo.collider.tag  == "Obstacle")
        {
            movement.enabled = false;
            explosion.Play();

            FindObjectOfType<Gamemanagers>().GameOver();
        }
    }
}
