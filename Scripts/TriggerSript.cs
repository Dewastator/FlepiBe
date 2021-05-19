using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSript : MonoBehaviour
{
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Ground")
        {
            var width = collision.GetComponent<SpriteRenderer>().size.x;
            var newGround = Instantiate(collision.gameObject, new Vector3(collision.transform.position.x + width, collision.transform.position.y, 0), Quaternion.identity);
            newGround.name = "Ground";
        }
        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        
        if (collision.tag == "Ground")
        {

            Destroy(collision.gameObject);
        }
        
    }
}
