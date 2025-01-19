
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

    public int level = 0;


    void Start()
    {
        shieldGameObject.SetActive(false);
        playerHasShield = false;
    }

    void Update()
    {
        if (level == 0)
        {
            if (Input.GetKey(KeyCode.A))
            {
                if (transform.position.x > -3f)
                {
                    transform.Translate(Vector3.left * Time.deltaTime * moveSpeed);
                }
                else
                {

                }

            }

            if (Input.GetKey(KeyCode.D))
            {
                if (transform.position.x < 3f)
                {
                    transform.Translate(Vector3.right * Time.deltaTime * moveSpeed);
                }

            }
        }

        if (level == 1)
        {
            if (level == 0)
            {
                if (Input.GetKey(KeyCode.A))
                {
                    if (transform.position.x > -63.9f)
                    {
                        transform.Translate(Vector3.left * Time.deltaTime * moveSpeed);
                    }
                    else
                    {

                    }

                }

                if (Input.GetKey(KeyCode.D))
                {
                    if (transform.position.x < -56f)
                    {
                        transform.Translate(Vector3.right * Time.deltaTime * moveSpeed);
                    }

                }
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