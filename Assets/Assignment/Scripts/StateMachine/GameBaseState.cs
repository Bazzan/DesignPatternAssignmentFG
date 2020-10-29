using UnityEngine;

[CreateAssetMenu (menuName ="GameManager/GameBaseState")]
public class GameBaseState : GameState
{
    /// <summary>
    /// all states inherit form this State;
    /// </summary>

    protected GameManager Owner;
    public override void Initialize(GameStateMachine owner)
    {
        this.Owner = (GameManager)owner;
    }
    public override void Enter()
    {
        PrintCurrentGameSate();
        Owner.Transition<GameCollectCommandsState>();
    }
    public void PrintCurrentGameSate()
    {
        Debug.Log(Owner.getCurrentGameState().ToString());
    }
    public override void HandelFixedUpdate()
    {
        base.HandelFixedUpdate();
    }
    public override void HandleUpdate()
    {
        base.HandleUpdate();
    }
}
