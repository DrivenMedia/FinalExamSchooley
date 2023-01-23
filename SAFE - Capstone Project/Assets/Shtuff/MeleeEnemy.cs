using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeEnemy : MonoBehaviour
{
    public float speed = 10;
    public float desiredPlayerDistance = 0;
    public Vector3 desiredTileVector3;
    public float closestDistance = 100;
    public GameManager gameManager;


    void Start()
    {
        
    }

    void Update()
    {
        closestDistance = 100;
        for (int i = 0; i < GameManager.tileTransforms.Length; i++)
        {
            if (Mathf.Sqrt((GameManager.tileTransforms[i].transform.position.x - transform.position.x) * (GameManager.tileTransforms[i].transform.position.x - transform.position.x) + (GameManager.tileTransforms[i].transform.position.y - transform.position.y) * (GameManager.tileTransforms[i].transform.position.y - transform.position.y)) <= 1f)
            {
                if (Mathf.Sqrt((GameManager.tileTransforms[i].transform.position.x - gameManager.player.transform.position.x) * (GameManager.tileTransforms[i].transform.position.x - gameManager.player.transform.position.x) + (GameManager.tileTransforms[i].transform.position.y - gameManager.player.transform.position.y) * (GameManager.tileTransforms[i].transform.position.y - gameManager.player.transform.position.y)) <= closestDistance)
                {
                    closestDistance = Mathf.Sqrt((GameManager.tileTransforms[i].transform.position.x - transform.position.x) * (GameManager.tileTransforms[i].transform.position.x - transform.position.x) + (GameManager.tileTransforms[i].transform.position.y - transform.position.y) * (GameManager.tileTransforms[i].transform.position.y - transform.position.y));
                    desiredTileVector3 = new Vector3(GameManager.tileTransforms[i].transform.position.x,GameManager.tileTransforms[i].transform.position.y,0);
                }
            }
        }
        transform.position = new Vector3(Mathf.MoveTowards(transform.position.x, desiredTileVector3.x, speed / 60f), Mathf.MoveTowards(transform.position.y, desiredTileVector3.y, speed / 60f), 0);
    }
}
