using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class PlayerHealth : MonoBehaviour
 {
    public int maxHealth = 100;
    public int curHealth;
    public float Iframes;
    public EnemyDamage enemy;
    public bool wasAttacked;
    public Text textbox;

    private void Start()
    {
        curHealth = maxHealth;

        enemy = FindObjectOfType<EnemyDamage>();

        textbox = GetComponentInChildren<Text>();
    }

    public void OnCollisionEnter(Collision attacked)
    {
        if (attacked.gameObject.CompareTag("Enemy") && wasAttacked == false)
        {
            wasAttacked = true;

            TakeDamage();

            Invoke(nameof(ResetDamage), Iframes);
            UpdateHealthText();
        }
    }

    private void ResetDamage()
    {
        wasAttacked = false;
    }

    public void Update()
    {
        UpdateHealthText();

        if (curHealth <= 0)
        {
            Die();
        }

        if (curHealth > maxHealth)
        {
            curHealth = maxHealth;
        }
    }

    public void Die()
    {

        Debug.Log("Game Over");
        SceneManager.LoadScene(2);
    }
    private void UpdateHealthText() 
    {
        textbox.text = "Health:" + curHealth + "/" + maxHealth;
    }
    public void TakeDamage()
    {
        curHealth -= enemy.AttackDamage;
    }
}

