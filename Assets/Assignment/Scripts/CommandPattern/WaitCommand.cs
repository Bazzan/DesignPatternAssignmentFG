using UnityEngine;

public class WaitCommand : Command
{
    public WaitCommand()
    {
        Debug.Log("WaitCommand Created");
    }
    public override void Execute()
    {
        Debug.LogError("This hero is waiting this turn");

    }

}
