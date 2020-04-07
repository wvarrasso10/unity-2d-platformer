using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickup : MonoBehaviour
{
    public int healthAmount;
    
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag.Equals("Player"))
        {
            Player player = col.gameObject.GetComponent<Player>();
            player.addHealth(healthAmount);
            Destroy(gameObject);
        }

    }
}
