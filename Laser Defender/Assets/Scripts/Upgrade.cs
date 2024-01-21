using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Upgrade : MonoBehaviour
{
    [SerializeField] float fallSpeed = 5f;
    ScoreKeeper scoreKeeper;
    
    
    void Start()
    {
        scoreKeeper = FindObjectOfType<ScoreKeeper>();
    }

    
    void Update()
    {
        if(scoreKeeper.GetScore() == 200)
        {
            SpawnUpgrade();
        }
        FallDown();
    }

    void FallDown()
    {
        transform.Translate(Vector2.down * fallSpeed * Time.deltaTime);

        if(transform.position.y < -10f)
        {
            Destroy(gameObject);
        }
    }
    void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.CompareTag("Player"))
        {
            //apply upgrade effect here
            Destroy(gameObject);
        }
    }

    void SpawnUpgrade()
    {
        Vector2 spawnPosition = new Vector2(Random.Range(-8f, 8f), 7f);
       // Instantiate(, spawnPosition, Quaternion.identity);
    }

}
