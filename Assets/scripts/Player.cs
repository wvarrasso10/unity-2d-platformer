using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Player : MonoBehaviour
{
    public Animator animator;
    public int maxHealth = 100;
    public int currentHealth;
    public HealthBar healthBar;
    public bool dead;
    public GameObject gameOverText, restartButton, camera;
    // Start is called before the first frame update
    void Start()
    {
        gameOverText.SetActive(false);
        restartButton.SetActive(false);
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
        gameOverText.SetActive(false);
        restartButton.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        
        
        
        
    }
    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag.Equals("Enemy"))
        {
            TakeDamage(20);
        }
        if (currentHealth <= 0)
        {
            animator.SetTrigger("dead");
            gameOverText.SetActive(true);
            restartButton.SetActive(true);

        }
    }
}
