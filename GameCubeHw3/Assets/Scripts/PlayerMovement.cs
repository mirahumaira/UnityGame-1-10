/*Author: Mir Afra Humaira
  Original Code: Brackeys
  Homework 4
  9/28/2020
  Submitted to: Prof Hao Tang
 
 */

using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
   

    public float forwardForce = 1000f;
    public float sidewaysForce = 1000f;
    public float increaseSpeed = 2000f;
    public float decreaseSpeed = 200f;


    // Update is called once per frame
    private void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("w"))
            forwardForce = increaseSpeed;

        if (Input.GetKey("s"))
            forwardForce = decreaseSpeed;

        if (Input.GetKey("d"))
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

        if (Input.GetKey("a"))
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

        // More efficient method.
        //rb.AddForce(Input.GetAxis("Horizontal") * 200 * Time.deltaTime, 0, 0);

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}

// Video link: https://youtu.be/1brNm7gL6ww

/* Which view enables you to manipulate objects in a scene visually?

Ans: Scene view

How many game objects did you create? Are assets and game objects the same?

Ans: 2 -- Player, Ground.
     No, Assets are files that you can use in the game objects to manipulate how they work. Game objects are game elements.

What happens if you double the value of rightforce? Why?

Ans: If you double the value of the sidewaysforce/ rightforce, it just moves 2x times faster. Because physics.

What is the class you have created in the Unity project? How many insance variables are there in the class?

Ans: The class created in the project is Player Movement. We have 5 instance variables.

What is a rigidbody?

Ans: RigidBody is a component of a game object that allows the object to use and apply properties of physics.

How do you modify your code to allow users to press "w" to speed up, and press "X" to slow down the object's movement? 

Ans: Given in the code.
 
 */ 