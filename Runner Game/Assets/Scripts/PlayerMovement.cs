
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 2f;

    public Animator animator;

    public int points = 0;

    public GameObject shieldGameObject;

    public bool playerHasShield = false;

    public AudioClip jumpSound;
    public AudioSource jumpAudioSource;
    
    public AudioSource soundTrackAudioSource;
    public AudioClip backgroundMusic;


    void Start()
    {
        shieldGameObject.SetActive(false);
        playerHasShield = false;
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

        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.Play("Jump");

            if (jumpAudioSource.isPlaying)
            {

            }

            else
            {
                jumpAudioSource.PlayOneShot(jumpSound);
            }

            jumpAudioSource.PlayOneShot(jumpSound);
        }

    }
}