using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public abstract class HeroStateMachine : MonoBehaviour
{
    // Attributes
    [SerializeField] private HeroState[] states;

    private Dictionary<Type, HeroState> stateDictionary = new Dictionary<Type, HeroState>();
    protected HeroState currentState;

    // Methods
    protected virtual void Awake()
    {
        foreach (HeroState state in states)
        {
            HeroState instance = Instantiate(state);
            instance.Initialize(this);
            stateDictionary.Add(instance.GetType(), instance);
            if (currentState == null)
                currentState = instance;
        }
        currentState.Enter();
    }

    public void Transition<T>() where T : HeroState
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

    public HeroState GetCurrentState()
    {
        return currentState;
    }


}
