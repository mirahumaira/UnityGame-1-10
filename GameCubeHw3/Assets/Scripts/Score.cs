/*Author: Mir Afra Humaira
  Original Code: Brackeys
  Homework 4
  9/28/2020
  Submitted to: Prof Hao Tang
 
 */
using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
{
    public Transform player;
    public Text scoreText;
    private int count;
    private void Start()
    {
         count = 0;
    }

    public void ScoreCount()
    {
         count++;
    }

    // Update is called once per frame
   private void Update()
    {
        //scoreText.text = player.position.z.ToString("0");
        scoreText.text = count.ToString();

    }
}
