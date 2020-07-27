using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        // use 'tag' is better than 'name'
        if(collision.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<GameManger>().EndGame();
        }
    }
}
