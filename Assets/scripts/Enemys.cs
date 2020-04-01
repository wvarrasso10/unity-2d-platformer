using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemys : MonoBehaviour
{
    public int maxHealth = 100;
    int currentHealth;
    public GameObject gameObject;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        
    }

    public void TakeDamage(int damage)
    {
        Debug.Log(damage);
        currentHealth -= damage;
        if(currentHealth <= 0)
        {
            Die();
        }
    }
    public void Die()
    {
        Debug.Log("enemy died");
        GameObject.Destroy(gameObject);
    }
}
