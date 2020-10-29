using UnityEngine;
[CreateAssetMenu(menuName = "GameManager/GameAttackState")]
public class GameActionState : GameBaseState
{
    /// <summary>
    /// This state fires the diffrent heros commandbuffer, one at a time; 
    /// </summary>
    float time;
    public override void Enter()
    {
        time = 0;
        base.PrintCurrentGameSate();
    }
    public override void Exit()
    {
        base.Exit();
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
    public void MoveHerosToCachedPosition()
    {
        Owner.CubeHero.transform.position = Owner.cubeCachedPos;
        Owner.SphereHero.transform.position = Owner.sphereCachedPos;
        Owner.CapsuleHero.transform.position = Owner.capsuleCachedPos;
    }

}
