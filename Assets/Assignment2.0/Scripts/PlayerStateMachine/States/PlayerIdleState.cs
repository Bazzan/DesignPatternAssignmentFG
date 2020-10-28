using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName = "PlayerStates/PlayerIdleState")]
public class PlayerIdleState : PlayerBase
{

    
    public override void Enter()
    {
        base.PrintState();
    }
    public override void HandleUpdate()
    {
        if (owner.playerCommandInvoker.commandBuffer.Count == 0) return;

        owner.playerCommandInvoker.ExecuteBuffer();
    }





}
