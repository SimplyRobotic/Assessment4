using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
  

    [SerializeField] Transform Respawn; // respawn point 
    public GameObject Player; // player 
    public int startLives = 5; // starting lives

    [SerializeField] Transform Win;

   

    void Start()
    {
       
       
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Hazard"))
        {
            Player.transform.position = Respawn.position;
            startLives = startLives - 1;
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
    }
  
   
}
