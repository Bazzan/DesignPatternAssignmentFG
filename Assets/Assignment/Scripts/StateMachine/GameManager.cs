
using JetBrains.Annotations;
using UnityEngine;

public class GameManager : GameStateMachine
{
    public CommandInvoker SphereCommandInvoker;
    public CommandInvoker CubeCommandInvoker;
    public CommandInvoker CapsuleCommandInvoker; 

    [Header("Characters")]
    public GameObject Target;
    public GameObject SphereHero;
    public GameObject CapsuleHero;
    public GameObject CubeHero;

    [HideInInspector]
    public int numberOfCommands;
    [HideInInspector]
    public Vector3 sphereCachedPos;
    [HideInInspector]
    public Vector3 capsuleCachedPos;
    [HideInInspector]
    public Vector3 cubeCachedPos;

    private void Start()
    {
        capsuleCachedPos = CapsuleHero.transform.position;
        cubeCachedPos = CubeHero.transform.position;
        sphereCachedPos = SphereHero.transform.position;


       SphereCommandInvoker = new CommandInvoker();
       CubeCommandInvoker = new CommandInvoker();
       CapsuleCommandInvoker = new CommandInvoker();
    }

    public void AddCommand()
    {
        if (numberOfCommands == 0)
           CubeCommandInvoker.AddCommand(new AttackCommand(CubeHero, Target, Random.Range(10f, 20f)));
        if (numberOfCommands == 1)
            SphereCommandInvoker.AddCommand(new AttackCommand(SphereHero, Target, Random.Range(10f, 20f)));
        if (numberOfCommands == 2)
           CapsuleCommandInvoker.AddCommand(new AttackCommand(CapsuleHero, Target, Random.Range(10f, 20f)));
        numberOfCommands++;
    }
}

