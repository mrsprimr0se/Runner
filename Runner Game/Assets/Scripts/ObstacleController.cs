using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleController : MonoBehaviour
{
    public PlayerMovement playerMovement;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z < -13f)
        {

            playerMovement.points++;

            // Dodac do gracza punkt

            Destroy(gameObject);
        }
    }
}
