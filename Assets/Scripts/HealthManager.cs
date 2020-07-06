using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour
{
    public Slider healthSlider;
    public float MAXHEALTH = 100f;
    public float health;
    void Start()
    {
        health = MAXHEALTH;
    }

    void Update()
    {
        
    }
    void Die()
    {
        GetComponent<PlayerBehaviour>().enabled = false;
        GetComponent<Animator>().SetBool("Dead", true);
    }
    public void TakeDamage(float amount)
    {
        health -= amount;

        if(health <= 0)
        {
            health = 0;
            Die();
        }

        healthSlider.value = health / MAXHEALTH;
    }
    public void Heal(float amount)
    {
        if (health != MAXHEALTH)
        {
            health += amount;
            Debug.Log("Healed");

            healthSlider.value = health / MAXHEALTH;

        }
        
    }
}
