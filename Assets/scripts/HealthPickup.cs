using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickup : MonoBehaviour
{
    public int healthAmount;
    
    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("pickup");
        if (col.gameObject.tag.Equals("Player"))
        {
            Debug.Log("pickup");
            Player player = col.gameObject.GetComponent<Player>();
            player.addHealth(healthAmount);
            Debug.Log("pickup");
            Destroy(gameObject);
        }

    }
}
