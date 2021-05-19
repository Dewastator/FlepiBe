using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{

    public GameObject gameOverCanvas;
    public GameObject startGameCanvas;
    [SerializeField]
    private bool isReplay;
    // Start is called before the first frame update
    
    private void Awake()
    {
        
    }
    public void Start()
    {
        if (PlayerPrefs.GetInt("isReplay") == 1)
        {
            
            StartGame();
            PlayerPrefs.SetInt("isReplay", 0);
            
        }
        else
        {
            startGameCanvas.SetActive(true);
            
            Time.timeScale = 0;
        }
        gameOverCanvas.SetActive(false);
    }
  
    public void StartGame()
    {
        startGameCanvas.SetActive(false);
        Time.timeScale = 1;

    }

    public void GameOver()
    {
        gameOverCanvas.SetActive(true);
        Time.timeScale = 0;
    }
    public void MainMenu()
    {
        PlayerPrefs.SetInt("isReplay", 0);
        SceneManager.LoadScene(0);
    }
    public void Replay()
    {
        
        PlayerPrefs.SetInt("isReplay", 1);
        SceneManager.LoadScene(0); ;
        
    }

    
}
