using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionDetect : MonoBehaviour
{
    public PlayerMovement playerMovement;

    public UIManager uiManager;


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
        if (collision.gameObject.tag == "Obstacle")
        {
            Debug.Log("Doszlo do kolizji z przeszkoda.");

            if (playerMovement.playerHasShield)
            {
                playerMovement.playerHasShield = false;
                playerMovement.shieldGameObject.SetActive(false);   
                uiManager.shieldIcon.enabled = false;   
            }

            else
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name); // scene manager wczytuje scene ktora aktualnie jest
            }
        }

        if (collision.gameObject.tag == "Shield")
        {
            Debug.Log("Zebrano tarcze.");
            playerMovement.playerHasShield = true;
            playerMovement.shieldGameObject.SetActive(true);

            uiManager.shieldIcon.enabled = true;

            Destroy(collision.gameObject);
        }

    }
}
