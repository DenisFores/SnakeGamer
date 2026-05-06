using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject gameOverUI;

    public void GameOver()
    {
        Time.timeScale = 0.3f;
        gameOverUI.SetActive(true);
    }

    public void Restart()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Exit()
    {
        Application.Quit();
    }
    void Start()
    {
        Time.timeScale = 1f;
        gameOverUI.SetActive(false);
    }
}