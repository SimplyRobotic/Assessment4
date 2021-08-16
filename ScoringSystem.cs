using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoringSystem : MonoBehaviour
{
    public Text scoreText;
    public static int score; // score count
   

    void Update()
    {
       // Displays score on UI
        scoreText.GetComponent<Text>().text = "Collected: " + score + "out of 10";
        
    }
}
