
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 2f;


    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            if (transform.position.x > -4f)
            {
                transform.Translate(Vector3.left * Time.deltaTime * moveSpeed);
            }
        }

        if (Input.GetKey(KeyCode.D))
        {
                if (transform.position.x < 4f)
                {
                    transform.Translate(Vector3.right * Time.deltaTime * moveSpeed);
                }
            
        }
    }
}