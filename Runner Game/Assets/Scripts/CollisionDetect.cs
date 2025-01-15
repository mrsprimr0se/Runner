using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionDetect : MonoBehaviour
{
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

            SceneManager.LoadScene(SceneManager.GetActiveScene().name); // scene manager wczytuje scene ktora aktualnie jest
        }

        if (collision.gameObject.tag == "Shield")
        {
            Debug.Log("Zebrano tarcze.");
        }

    }
}
