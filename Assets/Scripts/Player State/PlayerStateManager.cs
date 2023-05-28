using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStateManager<T> where T : Character
{
    private PlayerIState<T> currentState;
    private T typeClass;

    public void ChangeState<TState>(TState state) where TState : PlayerIState<T>
    {
        Debug.Log(currentState + " -> " + state);
        if (currentState != null)
        {
            currentState.OnExit(typeClass);
        }

        currentState = state;

        if (currentState != null)
        {
            currentState.OnStart(typeClass);
        }
    }
    public void UpdateState(T owner)
    {
        if (currentState != null)
        {
            currentState.OnExecute(owner);
        }
    }

    public void SetOwner(T owner)
    {
        typeClass = owner;
    }
}