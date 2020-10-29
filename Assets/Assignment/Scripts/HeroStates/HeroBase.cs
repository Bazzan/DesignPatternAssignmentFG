using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName = "Hero/HeroBase")]

public class HeroBase : HeroState
{
    
    

    protected Hero owner;

    public override void Initialize(HeroStateMachine owner)
    {
        this.owner = (Hero)owner;
    }

    public override void Enter()
    {
        owner.Transition<HeroCollectingCommands>();

    }

    public override void PrintState()
    {
        Debug.Log(owner.GetCurrentState().ToString());
    }

    protected void ExecuteHeroCommands()
    {
        owner.commandInvoker.ExecuteBuffer();
    }



}
