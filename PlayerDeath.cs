using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerDeath : MonoBehaviour
{
  

    [SerializeField] Transform Respawn; // respawn point 
    public GameObject Player; // player 
    public int startLives = 5; // starting lives
    public Text livesText; // Text for lives
    public Text winText; // Text for winning


    [SerializeField] Transform Win; // Win position. Player gets moved there once the winning condition is fulfilled

   

    void Start()
    {
       
       
    }
// Checks if the object collided is a hazard, and if so removes a life and sends the player to spawn
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Hazard"))
        {
            startLives--;
            Player.transform.position = Respawn.position;
            
        }

        // Kills player if out of lives
       if (startLives == 0)
        {
            Destroy(Player);
        }


    }
    void Update()
    {
        if (ScoringSystem.score == 10) // win condition
        {
            Player.transform.position = Win.position; // moves the player to Win position
            ScoringSystem.score++;
            winText.GetComponent<Text>().text = "You Win!"; // displays win text
        }

        livesText.GetComponent<Text>().text = "Lives: " + startLives; // lives UI, shows current number of lives
    }
  
   
}
