using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zvukovi : MonoBehaviour
{
    [SerializeField]
    AudioClip sirokoAudio;
    [SerializeField] [Range(0, 1)] float sirokoAudioVolume = 0.5f;
    bool isPlaying = false;
    int random;
    // Start is called before the first frame update
    void Start()
    {
        random = Random.Range(10, 20);
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Score.score == random && !isPlaying)
        {
            PlaySiroko();
            isPlaying = true;
        }
    }

    private void PlaySiroko()
    {
        AudioSource.PlayClipAtPoint(sirokoAudio, transform.position, sirokoAudioVolume);
       
    }
}
