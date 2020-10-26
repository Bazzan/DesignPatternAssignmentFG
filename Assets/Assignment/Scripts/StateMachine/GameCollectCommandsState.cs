using UnityEngine;

[CreateAssetMenu(menuName ="GameManager/GameCollectCommandsSTate")]
public class GameCollectCommandsState : GameBaseState
{
    public override void Enter()
    {
        PrintCurrentGameSate();
    }
    public override void HandleUpdate()
    {
        if (Owner.numberOfCommands > 2)
            CompleteCollecting();
    }
    public void CompleteCollecting()
    {
        Debug.Log("completed Collecting Commands");
        Owner.Transition<GameAttackState>();
    }
}
