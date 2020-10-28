using UnityEngine;
[CreateAssetMenu(menuName = "PlayerStates/PlayerBaseState")]
public class PlayerBase : PlayerState
{
    protected Player owner;

    public override void Initialize(PlayerStateMachine owner)
    {
        this.owner = (Player)owner;
    }

    public override void Enter()
    {
        PrintState();
        owner.Transition<PlayerIdleState>();
    }

    

    public override void PrintState()
    {
        Debug.Log(owner.GetCurrentState().ToString());
    }

    protected void ExecuteHeroCommands()
    {
        owner.playerCommandInvoker.ExecuteBuffer();
    }



}
