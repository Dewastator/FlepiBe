using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapAnimation : MonoBehaviour
{
    [SerializeField] Vector3 finalPosition;
    private Vector3 initialPosition;
    public static bool firstMap;
    // Start is called before the first frame update
    void Start()
    {
        if (firstMap)
        {
            initialPosition = transform.position;
            transform.position = finalPosition;
            return;
        }
        initialPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, finalPosition, 0.1f);
    }
    private void OnEnable()
    {
        
    }
    private void OnDisable()
    {
        transform.position = initialPosition;
    }
}
