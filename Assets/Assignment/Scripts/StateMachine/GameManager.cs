
using DesignPatternCourse.Observer;
using System.Net;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class GameManager : GameStateMachine
{
    public CommandInvoker SphereCommandInvoker;
    public CommandInvoker CubeCommandInvoker;
    public CommandInvoker CapsuleCommandInvoker;
    [Header("TextFields")]
    public TMP_Text CurrentCharacterName;
    [Header("Buttons")]

    public UnityEngine.UI.Button AttackButton;
    public UnityEngine.UI.Button EndRoundButton;
    [Header("Characters")]
    public GameObject Target;
    public GameObject SphereHero;
    public GameObject CapsuleHero;
    public GameObject CubeHero;
    [Header("Transforms")]
    public Transform attackPosition;

    //[HideInInspector]
    public int numberOfCommands;
    [HideInInspector]
    public Vector3 sphereCachedPos, capsuleCachedPos, cubeCachedPos;

    private void Start()
    {
        capsuleCachedPos = CapsuleHero.transform.position;
        cubeCachedPos = CubeHero.transform.position;
        sphereCachedPos = SphereHero.transform.position;


        SphereCommandInvoker = new CommandInvoker();
        CubeCommandInvoker = new CommandInvoker();
        CapsuleCommandInvoker = new CommandInvoker();
    }

    public void AddAttackCommand()
    {
        switch (numberOfCommands)
        {
            case 0:
                
                CapsuleCommandInvoker.AddCommand(new MoveCommand(
                    new Vector3(CapsuleHero.transform.position.x,
                    CapsuleHero.transform.position.y,
                    attackPosition.position.z),
                    CapsuleHero.transform));

                CapsuleCommandInvoker.AddCommand(new AttackCommand(
                    CapsuleHero, Target, Random.Range(10f, 20f)));

                CapsuleCommandInvoker.AddCommand(new MoveCommand(
                    capsuleCachedPos, CapsuleHero.transform));

                CurrentCharacterName.text = "No more commands to give -> End Round";
                numberOfCommands++;
                break;
            case 1:
                SphereCommandInvoker.AddCommand(new MoveCommand(
                    new Vector3(SphereHero.transform.position.x,
                    SphereHero.transform.position.y,
                    attackPosition.position.z),
                    SphereHero.transform));

                SphereCommandInvoker.AddCommand(
                    new AttackCommand(SphereHero, Target, Random.Range(10f, 20f)));

                SphereCommandInvoker.AddCommand(new MoveCommand(
                    sphereCachedPos, SphereHero.transform));

                CurrentCharacterName.text = "Sphere Hero";
                numberOfCommands++;
                break;
            case 2:
                CubeCommandInvoker.AddCommand(new MoveCommand(
                    new Vector3(CubeHero.transform.position.x,
                    CubeHero.transform.position.y,
                    attackPosition.position.z),
                    CubeHero.transform));

                CubeCommandInvoker.AddCommand(new AttackCommand(
                    CubeHero, Target, Random.Range(10f, 20f)));

                CubeCommandInvoker.AddCommand(new MoveCommand(
                    cubeCachedPos, CubeHero.transform));

                CurrentCharacterName.text = "Cube Hero";
                numberOfCommands++;
                break;
        }
    }
    public void AddWaitCommand()
    {
        switch (numberOfCommands)
        {
            case 0:
                CubeCommandInvoker.AddCommand(new WaitCommand());
                CurrentCharacterName.text = "Sphere Hero";
                numberOfCommands++;
                break;
            case 1:
                SphereCommandInvoker.AddCommand(new WaitCommand());
                CurrentCharacterName.text = "Cube Hero";
                numberOfCommands++;
                break;
            case 2:
                CapsuleCommandInvoker.AddCommand(new WaitCommand());
                CurrentCharacterName.text = "No more commands to give -> End Round";
                numberOfCommands++;
                break;
        }
    }

    public void OnEndRound()
    {
        Debug.Log("completed Collecting Commands");
        Transition<GameActionState>();

    }
}

