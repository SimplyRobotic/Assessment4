using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerDeath : MonoBehaviour
{
  

    [SerializeField] Transform Respawn; // respawn point 
    public GameObject Player; // player 
    public int startLives = 5; // starting lives
    public Text livesText;


    [SerializeField] Transform Win;

   

    void Start()
    {
       
       
    }

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
        if (ScoringSystem.score == 10)
        {
            Player.transform.position = Win.position;
            ScoringSystem.score++;
        }

        livesText.GetComponent<Text>().text = "Lives: " + startLives;
    }
  
   
}
