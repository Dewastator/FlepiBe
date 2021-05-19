using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipe;
    public float maxTime = 1;
    public float timer = 1.5f;
    public float height;

    // Update is called once per frame
    void Update()
    {
        if(timer > maxTime)
        {
            GameObject newPipes = Instantiate(pipe);
            if(newPipes.CompareTag("Zmaj"))
                newPipes.transform.position = transform.position + new Vector3(0, Random.Range(-height, 0.7f), 0);
            else 
                newPipes.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
            
            Destroy(newPipes, 5);
            timer = 0;
        }

        timer += Time.deltaTime;
    }

}



