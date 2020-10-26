using UnityEngine;

public class EnemyHelth : MonoBehaviour
{

    public float enemyHealth;



    public void TakeDamage(float damage)
    {
        enemyHealth -= damage;
        if(enemyHealth< 0f)
        {
            Die();
        }

    }


    private void Die()
    {
        gameObject.SetActive(false);
    }



}
