using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller;
    public Animator animator;
    
    public float runSpeed = 40f;
    float horizontalMove = 0f;
    bool jump = false;
    bool slash = false;
    public float attackRange = .5f;
    public Transform attackPoint;
    public LayerMask enemyLayers;
    public int attackDamage = 10;
    
// Update is called once per frame
void Update()
    {
        animator.SetFloat("speed", Mathf.Abs(horizontalMove));
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        attack();

    }
    void FixedUpdate()
    {
        //move the character
        controller.Move(horizontalMove*Time.fixedDeltaTime, false, jump);
        
        jump = false;
    }
    void attack()
    {
        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
        }
        if (Input.GetButtonDown("Vertical"))
        {
            slash = true;
            animator.SetBool("isAttack", slash);
        }
        else if (Input.GetButtonUp("Vertical"))
        {
            slash = false;
            animator.SetBool("isAttack", slash);
        }
        //detect enemies in range
        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayers);
        // damage enemies
        foreach (Collider2D enemy in hitEnemies)
        {
            if (Input.GetButtonDown("Vertical") || Input.GetButtonUp("Vertical"))
            {
                if (enemy.gameObject.tag.Equals("FlamingSkull"))
                    enemy.GetComponent<EnemyGFX>().TakeDamage(attackDamage);

                if (enemy.gameObject.tag.Equals("Goblin"))
                    enemy.GetComponent<goblin>().TakeDamage(attackDamage);

                if (enemy.gameObject.tag.Equals("Boss"))
                    Debug.Log("here");
                    enemy.GetComponent<Boss>().TakeDamage(attackDamage);
            }
        }
    }
    void OnDrawGizmosSelected()
    {
        if (attackPoint == null)
            return;
        
        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }
}
