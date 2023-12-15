using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{

    public AudioClip EnemyDeathSound;
    private AudioSource enemyAudio;
    private GameManager gameManager;
    public int pointValue;

    // Start is called before the first frame update
    void Start()
    {
        enemyAudio = GameObject.Find("Enemyaudio").GetComponent<AudioSource>();
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Laser"))
        {
            Destroy(gameObject);
            Destroy(other.gameObject); 
        }

        if(other.gameObject.CompareTag("Laser"))
        {
            enemyAudio.PlayOneShot(EnemyDeathSound, 0.68f);

        }

    }

    private void OnMouseDown()
    {
        Destroy(gameObject);
        gameManager.UpdateScore(pointValue); 
    }
}
