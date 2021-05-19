using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdMovement : MonoBehaviour
{
    public float speed = 1f;
    [SerializeField]
    AudioClip gameOverAudio;
    [SerializeField] [Range(0, 1)] float gameOverAudioVolume = 0.5f;
    public GameManager gameManager;
    [SerializeField]
    AudioClip FlyAudio;
    [SerializeField] [Range(0, 1)] float flyVolume = 0.5f;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && Time.timeScale != 0)
        {
            Fly();
        }
        
    }

    private void Fly()
    {
        var rb = GetComponent<Rigidbody2D>();

        AudioSource.PlayClipAtPoint(FlyAudio, Camera.main.transform.position, flyVolume);

        rb.velocity = Vector2.up * speed;
   
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        AudioSource.PlayClipAtPoint(gameOverAudio, Camera.main.transform.position, gameOverAudioVolume);
        gameManager.GameOver();
    }
}
