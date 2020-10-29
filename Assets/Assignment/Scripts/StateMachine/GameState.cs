using UnityEngine;

public class GameState : ScriptableObject
{
    /// <summary>
    /// All states inherit from gameState through GameBaseState
    /// </summary>
    

    public virtual void Initialize(GameStateMachine owner) { }
    public virtual void Enter() { }
    public virtual void Exit() { }
    public virtual void HandleUpdate() { }
    public virtual void HandelFixedUpdate() { }
}