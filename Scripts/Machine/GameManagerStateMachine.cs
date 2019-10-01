using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerStateMachine : StateMachine {
    [SerializeField] PauseState pause;
    private StateMachine stateMachine = new StateMachine();

    
    

    private void Start()
    {
        this.stateMachine.ChangeState(new GameState());
    }

    private void Update()
    {
        this.stateMachine.ExecuteStateUpdate();
        if (Input.GetKeyDown(KeyCode.P) )
        {
            this.stateMachine.ChangeState(new PauseState());
        }

        if (this.stateMachine.currentState == pause && Input.GetKeyUp(KeyCode.O))
        {
            this.stateMachine.ChangeState(new GameState());
        }
    }
}
