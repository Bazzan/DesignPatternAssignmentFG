using UnityEngine;

[CreateAssetMenu(menuName ="GameManager/GameCollectCommandsSTate")]
public class GameCollectCommandsState : GameBaseState
{

    private float numberOfCommands;

    public override void Enter()
    {

        PrintCurrentGameSate();
        Owner.numberOfCommands = 0;
        
        Owner.AttackButton.interactable = true;
        Owner.EndRoundButton.interactable = false;
        Owner.CurrentCharacterName.text = "Capsule Hero";

    }
    public override void HandleUpdate()
    {
        if (Owner.numberOfCommands > 2) { 
            Owner.AttackButton.interactable = false;
            Owner.EndRoundButton.interactable = true;
        }
    }
    //public void AddCommand()
    //{
    //    //if (numberOfCommands == 0)
    //    //    Owner.CubeCommandInvoker.AddCommand(new AttackCommand(Owner.CubeHero, Owner.Target, Random.Range(10f, 20f)));
    //    //Owner.CurrentCharacterName.text = "Sphere Hero";
    //    //Owner.CurrentCharacterName.text = "Cube Hero";
    //    //Owner.CurrentCharacterName.text = "No more commands to give -> End Round";

    //    //if (numberOfCommands == 1)
    //    //    Owner.SphereCommandInvoker.AddCommand(new AttackCommand(Owner.SphereHero, Owner.Target, Random.Range(10f, 20f)));

    //    //if (numberOfCommands == 2)
    //    //    Owner.CapsuleCommandInvoker.AddCommand(new AttackCommand(Owner.CapsuleHero, Owner.Target, Random.Range(10f, 20f)));

    //    //numberOfCommands++;
    //    if (numberOfCommands == 3)
    //    {
    //        Owner.AttackButton.interactable = false;
    //    }
    //}
}
