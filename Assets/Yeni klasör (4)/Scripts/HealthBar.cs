using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HealthBar : MonoBehaviour
{
    private Image HealthBar1;
    public float CurrentHealth;
    private float MaxHealth = 100f;
    PlayerController player;




    // Start is called before the first frame update
    void Start()
    {
        HealthBar1 = GetComponent<Image>();
        player = FindObjectOfType<PlayerController>();
        
    }

    // Update is called once per frame
    void Update()
    {
        CurrentHealth = player.Health;
        HealthBar1.fillAmount = CurrentHealth / MaxHealth;
    }
}
