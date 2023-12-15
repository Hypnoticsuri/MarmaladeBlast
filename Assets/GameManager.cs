using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    private int score;
    public TextMeshProUGUI scoreText;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(EnemyHit());
        UpdateScore(0);
    }

   IEnumerator EnemyHit()
    {
        while (true)
        {
            UpdateScore(5);
        }
    }

    public void UpdateScore(int scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.text = "Score;" + score;
    }

   
    // Update is called once per frame
    void Update()
    {
        
    }
}
