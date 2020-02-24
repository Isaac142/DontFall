using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public float timer;

    public Text timeText;

    public bool isPaused = false;
    public GameObject pausePanel;

    public bool isTitleScreen;
    public bool wonGame;

    public GameObject youWin;
    public GameObject youLost;
    public GameObject inGameHUD;

    public Respawn RP;

    public GameObject player;

    public PlayerCameraMovement PCMX, PCMY;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        int seconds = (int)(timer % 60);
        int minutes = (int)(timer / 60) % 60;

        string timerString = string.Format("{0:00}:{1:00}", minutes, seconds);

        timeText.text = timerString;

        if (timer <= 30)
        {
            timeText.text = "Time Left: " + timer.ToString("F2");
        }
        else
        {
            timeText.text = "Time Left: " + timerString;
        }

        if (!isTitleScreen)
        {
            timeText.text = "Time Left: " + timerString;
        }

        if (timer <= 0)
        {
            timer = 0f;
            Time.timeScale = 0f;
            PCMX.canMove = false;
            PCMY.canMove = false;
            youLost.SetActive(true);
            inGameHUD.SetActive(false);
        }
        else if (!isPaused && !wonGame)
        {
            Debug.Log("Not Paused");
            timer -= Time.deltaTime;
            Time.timeScale = 1f;
            PCMX.canMove = true;
            PCMY.canMove = true;
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isPaused = !isPaused;
            Pause(isPaused);
            if (isPaused)
            {
                Time.timeScale = 0f;
                PCMX.canMove = false;
                PCMY.canMove = false;
            }
        }
    }

    private void FixedUpdate()
    {

    }

    public void Pause(bool pause)
    {

        if (pausePanel != null)
        {
            pausePanel.SetActive(pause);
            inGameHUD.SetActive(!pause);

        }
    }
}