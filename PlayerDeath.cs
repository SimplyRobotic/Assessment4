using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
  

    [SerializeField] Transform Respawn; // respawn point 
    public GameObject Player; // player 
    public int startLives = 5; // starting lives

    [SerializeField] Transform Win;
    GameController gc;

    void Start()
    {
        // Finds GameController and gives access to the GameController Variables
        gc = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
       
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
        if (gc.collectible == 0)
        {
            Player.transform.position = Win.position;
            gc.collectible--;
        }
                     
    }
   
}
