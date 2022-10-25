using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager thisManager = null;
    [SerializeField] public Text Txt_Score;
    [SerializeField] public Text Txt_Message;
    private int Score = 0;

    void Start()
    {
        thisManager = this;
        Time.timeScale = 0;
    }

    void Update()
    {
        if (Time.timeScale == 0 && Input.GetKeyDown(KeyCode.Return))
            StartGame();
    }

    public void UpdateScore()
    {
        Score++;
        Txt_Score.text = "SCORE : " + Score;
    }

    public void StartGame()
    {
        Score = 0;
        Time.timeScale = 1f;
        Txt_Message.text = "";
        Txt_Score.text = "SCORE : 0";
    }

    public void Restart()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void GameOver()
    {
        SceneManager.LoadScene("GameOver");
    }
}
