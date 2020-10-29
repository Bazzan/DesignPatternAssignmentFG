using System.Collections.Generic;
using UnityEngine;
using System;

public abstract class GameStateMachine : MonoBehaviour
{
    /// <summary>
    /// This is a final state machine FSM that instantiate the diffrent states and 
    /// stores them in a dictionary for easy access to run metohds in the diffrent states
    /// like update and others.
    /// This stateMacine is keeping track on which state the game is in, when to collect commands 
    /// and when to execute the command buffer
    /// </summary>

    // Attributes
    [SerializeField] private GameState[] states;

    private Dictionary<Type, GameState> stateDictionary = new Dictionary<Type, GameState>();
    protected GameState currentState;

    // Methods
    protected virtual void Awake()
    {
        foreach (GameState state in states)
        {
            GameState instance = Instantiate(state);
            instance.Initialize(this);
            stateDictionary.Add(instance.GetType(), instance);
            if (currentState == null)
                currentState = instance;
        }
        currentState.Enter();
    }

    public void Transition<T>() where T : GameState
    {
        currentState.Exit();
        currentState = stateDictionary[typeof(T)];
        currentState.Enter();
    }

    private void Update()
    {
        currentState.HandleUpdate();
    }

    private void FixedUpdate()
    {
        currentState.HandelFixedUpdate();
    }

    public GameState getCurrentGameState()
    {
        return currentState;
    }
}
