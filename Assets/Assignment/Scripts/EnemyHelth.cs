using UnityEngine;
using UnityEngine.UI;

public class EnemyHelth : MonoBehaviour
{
    /// <summary>
    /// 
    /// Adds UpdateHealth() to the event when the object is enabled.
    /// it updates enemyHealth in TakeDamage(float damage) and fires OnTakingDamage in eventmanager
    /// 
    /// </summary>

    public float enemyHealth;
    public Slider HealthBar;

    ///
    private void OnEnable()
    {
        EventManager.OnTakingDamage += UpdateHealthBar;
    }
    private void OnDisable()
    {
        EventManager.OnTakingDamage -= UpdateHealthBar;
    }
    public void TakeDamage(float damage)
    {
        enemyHealth -= damage;
        EventManager.FireOnTakingDamage();
        if (enemyHealth < 0f)
        {
            Die();
        }
    }
    private void Die()
    {
        gameObject.SetActive(false);
    }
    private void UpdateHealthBar()
    {
        HealthBar.value = enemyHealth;
    }






}
