using UnityEngine;
[CreateAssetMenu(menuName = "GameManager/GameAttackState")]
public class GameAttackState : GameBaseState
{

    float time;
    public override void Enter()
    {
        time = 0;
        base.PrintCurrentGameSate();
        //MoveHerosToTarget();
    }
    public override void Exit()
    {
        base.Exit();
        MoveHerosToCachedPosition();
        //Owner.numberOfCommands = 0;
    }
    //public void MoveHerosToTarget()
    //{
    //    if (Owner.CapsuleCommandInvoker.commandBuffer.Count > 0)
    //        Owner.CapsuleHero.transform.position = new Vector3(Owner.CapsuleHero.transform.position.x, Owner.CapsuleHero.transform.position.y, Owner.attackPosition.position.z);
    //    if (Owner.SphereCommandInvoker.commandBuffer.Count > 0)
    //        Owner.SphereHero.transform.position = new Vector3(Owner.SphereHero.transform.position.x, Owner.SphereHero.transform.position.y, Owner.attackPosition.position.z);
    //    if (Owner.CubeCommandInvoker.commandBuffer.Count > 0)
    //        Owner.CubeHero.transform.position = new Vector3(Owner.CubeHero.transform.position.x, Owner.CubeHero.transform.position.y, Owner.attackPosition.position.z);
    //}

    public void MoveHerosToCachedPosition()
    {
        Owner.CubeHero.transform.position = Owner.cubeCachedPos;
        Owner.SphereHero.transform.position = Owner.sphereCachedPos;
        Owner.CapsuleHero.transform.position = Owner.capsuleCachedPos;
    }
    public override void HandleUpdate()
    {
        while (time < 1f)
        {
            time += Time.deltaTime;
            return;
        }
        Owner.CubeCommandInvoker.ExecuteBuffer();
        while (time < 2f)
        {
            time += Time.deltaTime;
            return;
        }
        Owner.SphereCommandInvoker.ExecuteBuffer();
        while (time < 3f)
        {
            time += Time.deltaTime;
            return;
        }
        Owner.CapsuleCommandInvoker.ExecuteBuffer();
        Owner.Transition<GameCollectCommandsState>();
    }

}
