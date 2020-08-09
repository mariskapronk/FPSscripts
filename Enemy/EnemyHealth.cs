using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour, IDamageable
{
    [SerializeField] private EnemyStats enemyStats;
    [SerializeField] private Slider healthbarSlider;
    [SerializeField] private Image healthbarFillImage;
    [SerializeField] private Color maxHealthColor;
    [SerializeField] private Color zeroHealthColor;

    private int currentHealth;

    private void Start()
    {
        currentHealth = enemyStats.maxHealth;
        SetHealthbarUi();
    }

    public void DealDamage(int damage)
    {
        currentHealth -= damage;
        CheckIfDead();
        SetHealthbarUi();
    }

    private void CheckIfDead()
    {
        if(currentHealth <=0)
        {
            Destroy(gameObject);
        }
    }

    private void SetHealthbarUi()
    {
        float healthPercentage = CalculateHealthPercentage();
        healthbarSlider.value = CalculateHealthPercentage();
        healthbarFillImage.color = Color.Lerp(zeroHealthColor, maxHealthColor, healthPercentage / 100);
    }

    private float CalculateHealthPercentage()
    {
        return ((float)currentHealth / (float)enemyStats.maxHealth) * 100;
    }
}
