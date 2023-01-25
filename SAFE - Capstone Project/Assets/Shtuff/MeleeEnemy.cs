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
    public bool isSearching = true;


    void Start()
    {
        desiredTileVector3 = new Vector3(transform.position.x,transform.position.y,transform.position.z);
    }

    void Update()
    {
        if (desiredTileVector3 == new Vector3(transform.position.x,transform.position.y,transform.position.z) && !isSearching)
        {
            isSearching = true;
        }
        if (isSearching)
        {
            closestDistance = 100;
            for (int i = 0; i < gameManager.tileTransforms.Length; i++)
            {
                float tileDistanceFromEnemy = Mathf.Sqrt((gameManager.tileTransforms[i].transform.position.x - transform.position.x) * (gameManager.tileTransforms[i].transform.position.x - transform.position.x) + (gameManager.tileTransforms[i].transform.position.y - transform.position.y) * (gameManager.tileTransforms[i].transform.position.y - transform.position.y));
                if (tileDistanceFromEnemy <= 1f)
                {
                    float tileDistanceFromPlayer = Mathf.Sqrt((gameManager.tileTransforms[i].transform.position.x - gameManager.player.transform.position.x) * (gameManager.tileTransforms[i].transform.position.x - gameManager.player.transform.position.x) + (gameManager.tileTransforms[i].transform.position.y - gameManager.player.transform.position.y) * (gameManager.tileTransforms[i].transform.position.y - gameManager.player.transform.position.y));
                    if (tileDistanceFromPlayer <= closestDistance)
                    {
                        closestDistance = tileDistanceFromPlayer;
                        desiredTileVector3 = new Vector3(gameManager.tileTransforms[i].transform.position.x,gameManager.tileTransforms[i].transform.position.y,0);
                    }
                }
            }
            isSearching = false;
        }
        transform.position = new Vector3(Mathf.MoveTowards(transform.position.x, desiredTileVector3.x, speed / 60f), Mathf.MoveTowards(transform.position.y, desiredTileVector3.y, speed / 60f), 0);
    }
}
