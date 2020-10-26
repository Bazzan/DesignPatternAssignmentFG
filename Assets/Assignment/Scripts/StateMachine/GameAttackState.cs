using UnityEngine;
[CreateAssetMenu(menuName ="GameManager/GameAttackState")]
public class GameAttackState : GameBaseState
{

    float time;
    public override void Enter()
    {
        time = 0;
        base.PrintCurrentGameSate();
        MoveHerosToTarget();
    }
    public override void Exit()
    {
        base.Exit();
        MoveHerosToCachedPosition();
        Owner.numberOfCommands = 0;
    }
    public void MoveHerosToTarget()
    {
        Owner.CubeHero.transform.position = Owner.Target.transform.position + Owner.Target.transform.forward;
        Owner.CapsuleHero.transform.position = Owner.Target.transform.position + Owner.Target.transform.forward;
        Owner.SphereHero.transform.position = Owner.Target.transform.position + Owner.Target.transform.forward;
    }

    public void MoveHerosToCachedPosition()
    {
        Owner.CubeHero.transform.position = Owner.cubeCachedPos;
        Owner.SphereHero.transform.position = Owner.sphereCachedPos;
        Owner.CapsuleHero.transform.position = Owner.capsuleCachedPos;
    }
    public override void HandleUpdate()
    {
        while(time < 1f)
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
