using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundController : MonoBehaviour
{
    public bool startMove;

    public float moveSpeed;

    public float incrementSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (startMove)
        {
            moveSpeed = moveSpeed + incrementSpeed * Time.deltaTime;

            Vector3 moveVector = new Vector3(0, 0, -1);
            transform.Translate(moveVector * Time.deltaTime * moveSpeed);
        }
    }
}
