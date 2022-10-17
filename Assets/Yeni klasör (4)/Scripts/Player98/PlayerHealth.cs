using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth;
    public static int currentHealth;
    public TextMeshProUGUI finishWriting;
    public TextMeshProUGUI healthWriting;
    public GameObject finishPanel;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }
    public int GetHealth()
    {
        return currentHealth;
    }
    public void DeductHealth(int damage)
    {
        currentHealth = currentHealth - damage;

        Debug.Log("Player's health decreased" + currentHealth);
        healthWriting.text = "Current Health : " + currentHealth.ToString();
        
        if (currentHealth <= 0)
        {
          
            KillPlayer();
            finishPanel.SetActive(true);
            finishWriting.text = "GAME OVER";
            Time.timeScale = 0;
            
        }
    }

    private void KillPlayer()
    {
        print("Player died");
    }

    public void AddHealth(int value)
    {

        currentHealth = currentHealth + value;
        if (currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
}
