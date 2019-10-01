using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine : MonoBehaviour {

    public IState currentState;
    public IState previousState;

	public void ChangeState(IState newState)
    {
        if (currentState != null)
            this.currentState.Exit();

        this.previousState = this.currentState;
        this.currentState = newState;
        this.currentState.Enter();
    }

    public void ExecuteStateUpdate()
    {
        if(currentState != null)
            this.currentState.Execute();
    }

    public void SwitchToPreviousState()
    {
        this.currentState.Exit();
        this.currentState = previousState;
        this.previousState.Enter();
    }
}
