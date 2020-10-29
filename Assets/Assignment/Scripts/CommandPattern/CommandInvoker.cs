using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommandInvoker
{
    /// <summary>
    /// CommandInvoker is containing the queue that stores the commands
    /// loops throgh the buffer and runs the execute method in each command
    /// </summary>
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
