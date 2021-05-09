using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EattingFish : MonoBehaviour
{
    float score;
    float health = 100;
    public Text ScoreText;
    public Text HealthText;
    
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        UpdateScore();
        UpdateHealth();
    }

    // Update is called once per frame
    void Update()
    {
        //checking if the player has lost
        if(health <= 0)
        {
            Debug.Log("game over");
            SceneManager.LoadScene(1);
        }
        
        if(score >= 2000)
        {
            SceneManager.LoadScene(2);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        //if the player runs into a good fish
        if (collision.gameObject.tag == "GoodFish")
        {
            Destroy(collision.gameObject);
            score += 100;
            UpdateScore();

        }
        //if the player runs into a badfish
        else if (collision.gameObject.tag == "BadFish")
        {
            Destroy(collision.gameObject);
            
            health -= 20;
            UpdateHealth();

        }
    }

    private void UpdateScore()
    {
        ScoreText.text = "Score: " + score.ToString();
    }

    private void UpdateHealth()
    {
        HealthText.text = "Health: " + health.ToString();
    }
}
