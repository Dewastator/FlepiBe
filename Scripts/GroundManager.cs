using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundManager : MonoBehaviour
{
    [SerializeField]
    GameObject ground;
    [SerializeField]
    Transform right;
    // Start is called before the first frame update
    void Start()
    {

        Instantiate(ground, new Vector3(right.position.x, 0f, 0f), Quaternion.identity);
    }


}
