using UnityEngine;

public class MoveCommand : Command
{

    public MoveCommand()
    {
        Debug.Log("MoveCommand created");
    }

    public override void Execute()
    {
        player.Transition<PlayerMoveState>();
    }

}

