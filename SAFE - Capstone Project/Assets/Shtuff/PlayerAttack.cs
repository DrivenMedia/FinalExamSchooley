using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    GameObject weapon, player;

    Vector2 screenPosition, worldPosition, zeroPoint;
    // Vector3 rotation;
    void Start()
    {
        // weapon = gameObject.transform.GetChild(1).gameObject;
        weapon = gameObject;
        player = GameObject.Find("Player");
    }

    void Update()
    {
        screenPosition = Input.mousePosition;
        worldPosition = Camera.main.ScreenToWorldPoint(screenPosition);
        zeroPoint = new Vector2(worldPosition.x - transform.position.x, worldPosition.y - transform.position.y);
        if(worldPosition.x > transform.position.x) weapon.transform.rotation = Quaternion.Euler(0, 0, (Mathf.Atan(zeroPoint.y/zeroPoint.x) * (180 / Mathf.PI)) - 90);
        else weapon.transform.rotation = Quaternion.Euler(0, 0, ((Mathf.Atan(zeroPoint.y/zeroPoint.x) * (180 / Mathf.PI)) + 90));
        
    }
}
