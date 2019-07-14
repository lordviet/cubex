using UnityEngine;

public class PlayerCollision : MonoBehaviour {

    public PlayerMovement movement; //A reference to the player movement script

    void OnCollisionEnter(Collision collisionInfo) 
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            Debug.Log("We hit an obstacle!");
            movement.enabled = false; //Disable the player movement
            FindObjectOfType<GameManager2>().EndGame();

        }
    }

}
