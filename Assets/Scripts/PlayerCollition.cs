using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollition : MonoBehaviour
{
    public PlayerBehaviourScript movement;
    public GameManager gameManager;
    void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            FindAnyObjectByType<GameManager>().EndGame();
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
