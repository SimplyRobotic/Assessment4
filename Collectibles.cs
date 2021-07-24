using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectibles : MonoBehaviour
{
    GameController gc;

    // Start is called before the first frame update
    void Start()
    {
        // Finds GameController and gives access to the GameController Variables
        gc = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
        gc.collectible++;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            Destroy(gameObject);
            gc.collectible--;
        }
    }
}
