using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    // Use this for initialization
    
     GameObject _player;
    [SerializeField] GameObject _GameOverPanel;
    public UIManager uiManager;
    public bool isGameOn;
    public bool isPreGame;
    public bool isPaused;
    

    private void Start()
    {
        _player = GameObject.Find("Player");
        //_GameOverPanel = GameObject.Find("GameOverPanel");
        //Instantiate(_player);

        
    }
    private void Update()
    {
        if (_player.transform.position.y > 4.5)
        {
            GameOver();
        }

        if (Input.GetKeyDown(KeyCode.P) && isPaused == false){
            Pause();
        }
        else if(Input.GetKeyDown(KeyCode.P) && isPaused == true)
        {
            Resume();
        }

    }

    void GameOver()
    {
        
        _player.SetActive(false);
        _GameOverPanel.SetActive(true);

        
    }

    void Pause()
    {
        isPaused = true;
        uiManager.PausePanel.SetActive(true);
        //uiManager.GamePlayPanel.SetActive(false);
        Time.timeScale = 0;
    }

    void Resume()
    {
        isPaused = false;
        uiManager.PausePanel.SetActive(false);

        Time.timeScale = 1;
    }
}
