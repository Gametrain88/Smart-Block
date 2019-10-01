using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {

    // Use this for initialization
    public GameObject gameManager;
    public GameObject GameOverPanel;
    public GameObject GamePlayPanel;
    
    public GameObject PausePanel;
    public GameObject player;
    public Text score;
    public Text height;

	void Start () {
        
        GameOverPanel.SetActive(false);

	}
	
	// Update is called once per frame
    public void RestartGame()
    {
        SceneManager.LoadScene("gameScene");
        Time.timeScale = 1;
    }

    public void GotoMainMenu()
    {
        SceneManager.LoadScene("Main Menu");
        Time.timeScale = 1;
    }

    public void UpdateScore()
    {
        score.text = ("Score: " + (Mathf.CeilToInt(player.transform.position.x + 10)).ToString());
    }

    public void UpdateHeight()
    {
        height.text = ("Height: " + (Mathf.CeilToInt(player.transform.position.y + 10)).ToString());
    }

    private void Update()
    {
        UpdateScore();
        UpdateHeight();
    }

}
