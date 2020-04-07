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
    public GameObject gameOverText, restartButton;
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
    
    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
    }
    public void addHealth(int healthAmount)
    {
        currentHealth += healthAmount;
        if(currentHealth >= maxHealth)
        {
            currentHealth = maxHealth;
        }
        healthBar.SetHealth(currentHealth);
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag.Equals("FlamingSkull"))
        {
            SoundManger.PlaySound("hitSound");
            TakeDamage(10);
        }
        if (col.gameObject.tag.Equals("Goblin"))
        {
            SoundManger.PlaySound("hitSound");
            TakeDamage(20);
        }
        if (col.gameObject.tag.Equals("Spikes"))
        {
            SoundManger.PlaySound("hitSound");
            TakeDamage(100);
        }
        if (col.gameObject.tag.Equals("Boss"))
        {
            SoundManger.PlaySound("hitSound");
            TakeDamage(25);
        }

        if (currentHealth <= 0)
        {
            animator.SetTrigger("dead");
            gameOverText.SetActive(true);
            restartButton.SetActive(true);

        }
    }
}
