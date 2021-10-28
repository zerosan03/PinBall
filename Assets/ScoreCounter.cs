using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
    Material myMaterial;
    private GameObject gamescore;
    private int score=0;
    void Start()
    {
        this.gamescore = GameObject.Find("GameScore");
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "SmallStarTag")
        {
            score += 20;
        }
        else if (collision.collider.tag == "LargeStarTag")
        {
            score += 15;
        }
        else if (collision.collider.tag == "SmallCloudTag")
        {
            score += 10;
        }
        else if (collision.collider.tag == "LargeCloudTag")
        {
            score += 5;
        }

        this.gamescore.GetComponent<Text>().text = "score:" + score;
    }
}
