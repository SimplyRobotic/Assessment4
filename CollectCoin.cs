using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCoin : MonoBehaviour
{
    public GameObject Collectible;

    void OnTriggerEnter2D(Collider2D other)
    {

        ScoringSystem.score++;        
        Destroy(Collectible);
    }
}
