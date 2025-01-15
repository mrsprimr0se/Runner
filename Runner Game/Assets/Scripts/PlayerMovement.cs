
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 2f;

    public Animator animator;

    public int points = 0;


    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            if (transform.position.x > -3f)
            {
                transform.Translate(Vector3.left * Time.deltaTime * moveSpeed);
            }
        }

        if (Input.GetKey(KeyCode.D))
        {
                if (transform.position.x < 3f)
                {
                    transform.Translate(Vector3.right * Time.deltaTime * moveSpeed);
                }
            
        }

        if (Input.GetKey(KeyCode.Space))
        {
            animator.Play("Jump");
        }

    }
}