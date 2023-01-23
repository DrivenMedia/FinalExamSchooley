using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttackScript : MonoBehaviour
{
    [SerializeField] private List<GameObject> enemies = new List<GameObject>();
    [SerializeField] private GameObject AttackArea;

    int attackDelay;

    public List<GameObject> GetColliders () 
    { 
        return enemies; 
    }

    void Start()
    {
        Application.targetFrameRate = 60;
    }

    void Update()
    {
        attackDelay--;
        if(Input.GetKeyDown("space")) PlayerAttack();
    }

    private void OnTriggerEnter (Collider other) 
    {
        if (!enemies.Contains(other.gameObject) && other.gameObject.tag == "Enemy") { enemies.Add(other.gameObject); }
    }
 
    private void OnTriggerExit (Collider other) 
    {
        enemies.Remove(other.gameObject);
    }

    void PlayerAttack()
    {
        if(enemies.Count > 0 && attackDelay <= 0)
        {
            for(int i = 0; i < enemies.Count; i++)
            {
                Debug.Log("hit");
                // enemies[i].TakeDamage(Player.playerDamage);
                attackDelay = 60;
            }
        }
    }
}
