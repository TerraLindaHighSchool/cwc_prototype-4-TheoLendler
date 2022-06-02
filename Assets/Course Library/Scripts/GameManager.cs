using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public bool gameActive = false;
    public GameObject titleScreen;
    public Button startButton;
    public Button restartButton;
    private SpawnManager spawnManager;
    void Start()
    {
        spawnManager = GameObject.Find("SpawnManager").GetComponent<SpawnManager>();
        startButton.onClick.AddListener(startGame);
        restartButton.onClick.AddListener(restartGame);
    }

    void startGame()
    {
        gameActive = true;
        titleScreen.SetActive(false);
    }

    void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
