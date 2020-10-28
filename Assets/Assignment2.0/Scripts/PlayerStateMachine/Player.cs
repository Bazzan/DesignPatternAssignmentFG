using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Player : PlayerStateMachine
{

    public CommandInvoker playerCommandInvoker;

    public NavMeshAgent playerAgent;
    public PlayerInputManager playerInputManager;

    private void Awake()
    {
        base.Awake();
        playerAgent = StaticRefrences.instance.playerAgent;
        playerCommandInvoker = StaticRefrences.instance.playerCommandInvoker;
    }


    public void MoveToPosition(Vector3 targetPosition)
    {
        playerAgent.SetDestination(targetPosition);
    }

}
