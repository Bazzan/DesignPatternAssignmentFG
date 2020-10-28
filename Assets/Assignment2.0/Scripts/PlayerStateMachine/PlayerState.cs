using UnityEngine;

public class PlayerState : ScriptableObject
{
    public virtual void Initialize(PlayerStateMachine owner) { }
    public virtual void Enter() { }
    public virtual void Exit() { }
    public virtual void HandleUpdate() { }
    public virtual void HandelFixedUpdate() { }
    public virtual void PrintState() { }

}