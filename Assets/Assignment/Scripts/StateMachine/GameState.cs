using UnityEngine;

public class GameState : ScriptableObject
{
    public virtual void Initialize(GameStateMachine owner) { }
    public virtual void Enter() { }
    public virtual void Exit() { }
    public virtual void HandleUpdate() { }
    public virtual void HandelFixedUpdate() { }
}