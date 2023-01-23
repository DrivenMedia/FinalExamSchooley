using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody playerRigidbody;
    public Collider playerCollider;
    public float playerSpeed;
    
    void Start()
    {
        
    }

    void Update()
    {
        if (InputHandler.upRightInput)
        {
            playerRigidbody.velocity = new Vector3(playerSpeed / Mathf.Sqrt(2), playerSpeed / Mathf.Sqrt(2), 0);
        }
        else if (InputHandler.upLeftInput)
        {
            playerRigidbody.velocity = new Vector3(-1f * playerSpeed / Mathf.Sqrt(2), playerSpeed / Mathf.Sqrt(2), 0);
        }
        else if (InputHandler.downRightInput)
        {
            playerRigidbody.velocity = new Vector3(playerSpeed / Mathf.Sqrt(2), -1f * playerSpeed / Mathf.Sqrt(2), 0);
        }
        else if (InputHandler.downLeftInput)
        {
            playerRigidbody.velocity = new Vector3(-1f * playerSpeed / Mathf.Sqrt(2), -1f * playerSpeed / Mathf.Sqrt(2), 0);
        }
        else if (InputHandler.upInput)
        {
            playerRigidbody.velocity = new Vector3(0, playerSpeed / Mathf.Sqrt(2), 0);
        }
        else if (InputHandler.downInput)
        {
            playerRigidbody.velocity = new Vector3(0, -1 * playerSpeed / Mathf.Sqrt(2), 0);
        }
        else if (InputHandler.rightInput)
        {
            playerRigidbody.velocity = new Vector3(playerSpeed / Mathf.Sqrt(2), 0, 0);
        }
        else if (InputHandler.leftInput)
        {
            playerRigidbody.velocity = new Vector3(-1 * playerSpeed / Mathf.Sqrt(2), 0, 0);
        }
        else
        {
            playerRigidbody.velocity = new Vector3(0,0,0);
        }
    }
}
