using System.Collections;
using UnityEngine;

public class CommandManager : MonoBehaviour
{
    public GameObject target;
    public GameObject character;
    //CommandInvoker commandInvoker = new CommandInvoker();

    //public void Attack()
    //{
    //    commandInvoker.AddCommand(new AttackCommand(character, target, Random.Range(10f, 20f)));
    //}

    //public void EndRound()
    //{
    //    commandInvoker.ExecuteBuffer();
    //}

    public IEnumerator GoToTarget(GameObject character, GameObject target)
    {
        character.transform.position = target.transform.position + target.transform.forward;
        yield return new WaitForSeconds(2.5f);
    }
}
