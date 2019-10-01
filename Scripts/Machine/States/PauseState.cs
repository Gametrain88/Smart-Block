using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseState : IState {

    private GameManager _gameManager;
    private UIManager _uiManager;


    void Start()
    {
        
    }

    public void Enter()
    {
        Debug.Log("yes!");
        _gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        _uiManager = GameObject.Find("UIManager").GetComponent<UIManager>();
        _gameManager.isPaused = true;
        
    }
    
    public void Execute()
    {
        Debug.Log("working");
        Time.timeScale = 0;
        _uiManager.PausePanel.SetActive(true);
    }


    public void Exit()
    {
        Debug.Log("Exiting");
        _gameManager.isPaused = false;
        Time.timeScale = 1;

    }


}
