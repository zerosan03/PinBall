using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
    Material myMaterial;
    private GameObject gamescore;
    private int score=0;
    private int degree = 0;
    private int speed = 5;
    void Start()
    {
        this.gamescore = GameObject.Find("GameScore");
        
    }

    // Update is called once per frame
    void Update()
    {
        if (this.degree > 0)
        {
            if (tag == "SmallStarTag")
            {
                score += 20;
            }
            else if (tag == "LargeStarTag")
            {
                score += 15;
            }
            else if (tag == "LargeCloudTag")
            {
                score += 5;
            }
            else if (tag == "SmallCloudTag")
            {
                score += 10;
            }
            this.gamescore.GetComponent<Text>().text = "score:" + score;
            this.degree -= this.speed;
        }
    }
    void OnCollisionEnter(Collision other)
    {
        this.degree = 5;
    }
}
