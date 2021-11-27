/*Author: Mir Afra Humaira
  Original Code: Brackeys
  Homework 4
  9/28/2020
  Submitted to: Prof Hao Tang
 
 */
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    //public GameManager gameManager;

   private void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "Obstacle")
        {
            // Debug.Log("We hit an obstacle.");
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
