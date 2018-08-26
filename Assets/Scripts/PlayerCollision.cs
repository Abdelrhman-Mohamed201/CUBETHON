using UnityEngine;

[RequireComponent(typeof(AudioSource))]

public class PlayerCollision : MonoBehaviour {

    public PlayerMovement movement;

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            // Stop the player movement.
            movement.enabled = false;

            // To select the GameManager object.
            FindObjectOfType<GameManager>().EndGamge();
        }
    }
}
