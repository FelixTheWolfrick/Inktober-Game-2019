using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    //Variables
    public int score;
    public Text scoreDisplay;
    public Text finalScoreDisplay;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreDisplay.text = score.ToString();
        finalScoreDisplay.text = "You Died! \n Score: " + score.ToString();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        //Set component for play & enemy
        GameObject player = GameObject.Find("Player");
        GameObject enemy = GameObject.Find("Enemy");

        //Only add to score if player is alive
        if (player.GetComponent<PlayerMovement>().health > 0)
        {
            score++;
            Destroy(enemy);
        }

        //Keep destroying obstacles even when players dead
        Destroy(enemy);
    }
}
