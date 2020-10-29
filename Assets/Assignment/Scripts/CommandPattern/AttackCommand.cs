using System.Collections;
using UnityEngine;

public class AttackCommand : Command
{
    /// <summary>
    /// Example of a command, a constructor that stores some data the can be
    /// used in the execute method that handels the functionality/gamelogic
    /// in this case it takes in a target and a damage amount. When the commandBuffer 
    /// runs through the queue it will run the execute method.
    /// </summary>

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
    }
}
