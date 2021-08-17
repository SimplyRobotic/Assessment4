using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCoin : MonoBehaviour
{
    public GameObject Collectible;
    public AudioSource collectSound;
// Checks for collision and destroys collectable, then add 1 to the score
    void OnTriggerEnter2D(Collider2D other)
    {

        ScoringSystem.score++;        
        Destroy(Collectible);
        collectSound.Play();
    }
}
