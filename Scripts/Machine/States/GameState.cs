using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameState : IState {

    private GameManager _gameManager;
    private UIManager _uiManager;

    public void Enter()
    {
        _gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        _uiManager = GameObject.Find("UIManager").GetComponent<UIManager>();
        Time.timeScale = 1;
        
    }

    public void Execute()
    {
        
    }

    public void Exit()
    {
        
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
