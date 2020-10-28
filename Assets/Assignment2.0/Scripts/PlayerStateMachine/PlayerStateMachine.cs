using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public abstract class PlayerStateMachine : MonoBehaviour
{
    // Attributes
    [SerializeField] private PlayerState[] states;

    private Dictionary<Type, PlayerState> stateDictionary = new Dictionary<Type, PlayerState>();
    protected PlayerState currentState;

    // Methods
    protected virtual void Awake()
    {
        foreach (PlayerState state in states)
        {
            PlayerState instance = Instantiate(state);
            instance.Initialize(this);
            stateDictionary.Add(instance.GetType(), instance);
            if (currentState == null)
                currentState = instance;
        }
        currentState.Enter();
    }

    public void Transition<T>() where T : PlayerState
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

    public PlayerState GetCurrentState()
    {
        return currentState;
    }


}
