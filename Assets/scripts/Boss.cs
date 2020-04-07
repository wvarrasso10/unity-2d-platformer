using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;
public class Boss : MonoBehaviour
{
    public AIPath aiPath;
    public Animator animator;
    public int maxHealth = 10;
    int currentHealth;
    public GameObject enemy,blood;
    bool walk;
    public bool drops;
    public GameObject theDrop;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;

    }

    public void TakeDamage(int damage)
    {
        Debug.Log("here");
        currentHealth -= damage;
        if (currentHealth <= 0)
        {
            Instantiate(blood, transform.position, Quaternion.identity);
            Die();
        }
    }
    public void Die()
    {

        GameObject.Destroy(enemy);
        if (drops) Instantiate(theDrop, transform.position, transform.rotation);
    }
    // Update is called once per frame
    void Update()
    {
        if (aiPath.desiredVelocity.x >= 0.01f)
        {
            walk = true;
            animator.SetBool("Walk", walk);
            transform.localScale = new Vector3(1f, 1f, 1f);
        }
        else if (aiPath.desiredVelocity.x <= -0.01f)
        {
            transform.localScale = new Vector3(-1f, 1f, 1f);
            walk = true;
            animator.SetBool("Walk", walk);
        }
    }
    void OnTriggerEnter2D(Collider2D col)
    {

        if (col.gameObject.tag.Equals("Player"))
        {

            animator.SetTrigger("attack");
        }

    }
}
