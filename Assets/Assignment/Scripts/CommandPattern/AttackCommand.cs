using System.Collections;
using UnityEngine;

public class AttackCommand : Command
{
    private float damage;
    private GameObject character;
    private GameObject target;
    private Vector3 cachedPos;

    public AttackCommand(GameObject character , GameObject target, float damage )
    {
        this.character = character;
        this.damage = damage;
        this.target = target;
        cachedPos = character.transform.position;
        Debug.Log("attackCommand created");
    }


    public override void Execute()
    {
        Debug.LogError($"attackCommand  by {this.character.name}");
        
        target.GetComponent<EnemyHelth>().TakeDamage(damage);

        character.transform.position = cachedPos;

    }
}
