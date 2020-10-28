using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHelth : MonoBehaviour , IDamagable
{

    public delegate void OnTakeDamageDelegate(float damage);
    public static event OnTakeDamageDelegate onTakingDamage;

    public Slider slider;
    public float enemyHealth;
    public Material material;


    private void OnEnable()
    {
        onTakingDamage += TakeDamage;
        onTakingDamage += UpdateHealthBar;
        onTakingDamage += StartHitVFX;
    }

    private void Start()
    {
        slider.value = enemyHealth;
    }
    public void TakeDamage(float damage)
    {
        enemyHealth -= damage;
        if(enemyHealth< 0f)
        {
            Die();
        }

    }

    public void UpdateHealthBar(float health)
    {
        slider.value = enemyHealth;
    }

    private void Die()
    {
        gameObject.SetActive(false);
    }

    public void FireTakeDamageEvent(float damage)
    {
        onTakingDamage(damage);
    }

    public void StartHitVFX(float secs)
    {
        StartCoroutine(HitVFX(0.25f));
    }

    public IEnumerator HitVFX(float seconds)
    {
        Color color = material.color;
        material.color = Color.red;
        yield return new WaitForSeconds(seconds);
        material.color = color;
    }


}
