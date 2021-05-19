using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveGround : MonoBehaviour
{
    public float speed;
    public static MoveGround Instance;
    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
    }
    
    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }
}
