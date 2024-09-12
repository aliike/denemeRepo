using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the object that collided is the player (you can identify the player by tag)
        if (other.CompareTag("Player"))
        {
            // Destroy the coin game object to make it disappear
            Destroy(gameObject);
        }
    }
}
