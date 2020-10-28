using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommandInvoker : MonoBehaviour
{
    public Queue<Command> commandBuffer = new Queue<Command>();

    public void AddCommand(Command command)
    {
        commandBuffer.Enqueue(command);
    }
    public void ExecuteBuffer()
    {

        foreach (Command command in commandBuffer)
        {
            command.Execute();

        }
        commandBuffer.Clear();
    }




}
