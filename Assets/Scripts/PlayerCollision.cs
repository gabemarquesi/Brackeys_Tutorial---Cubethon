using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public PlayerMovement movement;
    public ScoreText score;

    void OnCollisionEnter(Collision collisionInfo)         
    { 
        if(collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            score.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }

}
