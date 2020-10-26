using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public abstract class GameStateMachine : MonoBehaviour
{
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
