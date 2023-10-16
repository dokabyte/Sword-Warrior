using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int health;
    public int maxHealth = 10;

    public SpriteRenderer playerSR;
    public PlayerBehaviour PlayerBehaviour;
    private Animator anim;
    private bool dead;

    // Start is called before the first frame update
    private void Awake()
    {
        anim = GetComponent<Animator>();
    }

    void Start()
    {
        health = maxHealth;
    }

    public void TakeDamage(int amount)
    {
        health -= amount;
        if(health <= 0)
        {
            playerSR.enabled = false;
            PlayerBehaviour.enabled = false;
        }

        if (health > 0)
        {
            anim.SetTrigger("hurt");

        }
        
        else
        {
            if (dead)
            {
            anim.SetTrigger("die");
            GetComponent<PlayerBehaviour>().enabled = false;
                dead = true;

            }
        }

    }
}
