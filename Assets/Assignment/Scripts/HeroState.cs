using UnityEngine;

public class HeroState : ScriptableObject
{
    public virtual void Initialize(HeroStateMachine owner) { }
    public virtual void Enter() { }
    public virtual void Exit() { }
    public virtual void HandleUpdate() { }
    public virtual void HandelFixedUpdate() { }
    public virtual void PrintState() { }

}