using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "PlayerStates/PlayerMoveState")]
public class PlayerMoveState : PlayerBase
{

    public override void Enter()
    {
        base.PrintState();
        owner.MoveToPosition(owner.playerInputManager.ClickedPosition);
    }


    public override void HandleUpdate()
    {
        if (owner.playerAgent.hasPath) return;

        owner.Transition<PlayerIdleState>();
    }

}
