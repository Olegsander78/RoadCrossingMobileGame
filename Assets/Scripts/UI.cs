using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class UI : MonoBehaviour
{
    public TextMeshProUGUI ScoreText;
    public GameObject EndScreen;
    public GameObject WinText;
    public GameObject GameOverText;

    public static UI Instance;

    private void Awake()
    {
        Instance = this;
    }

    public void UpdateScoreText(int score)
    {
        ScoreText.text = "Score: " + score.ToString();
    }

    public void SetEndScreen(bool didWin)
    {
        EndScreen.SetActive(true);
        WinText.SetActive(didWin);
        GameOverText.SetActive(!didWin);
    }

    public void OnRestartButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
