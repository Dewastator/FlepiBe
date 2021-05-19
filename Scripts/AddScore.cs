using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddScore : MonoBehaviour
{
    [SerializeField]
    AudioClip pointSound;
    [SerializeField] [Range(0, 1)] float pointVolume = 0.5f;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {

            Score.score++;
            AudioSource.PlayClipAtPoint(pointSound, Camera.main.transform.position, pointVolume);
        }
    }
}
