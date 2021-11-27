/*Author: Mir Afra Humaira
  Original Code: Brackeys
  Homework 4
  9/28/2020
  Submitted to: Prof Hao Tang
 
 */
using UnityEngine;

public class ObstaclePassed : MonoBehaviour
{
    //public PlayerMovement movement;
    public Transform player;
    public Material obsMaterial;
    public Score obsCount;

    bool obstaclePassed = false;

    // Update is called once per frame
    private void Update()
    {
        if (!obstaclePassed)
        {
            if (player.position.z > transform.position.z)
            {
                Debug.Log("Player: " + player.position.z);
                Debug.Log("Transform: " + transform.position.z);
                GetComponent<MeshRenderer>().material = obsMaterial;
                obsCount.ScoreCount();
                obstaclePassed = true;
            }
            
        }
        
    }
}
