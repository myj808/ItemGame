
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public UIManager uiManager;

    private int targetCount = 0;
    private int collectedCount = 0;
    private bool isGameOver = false;

    void Awake()
    {
        if (Instance == null) Instance = this;
    }

    public void SetTargetCount(int count)
    {
        targetCount = count;
        collectedCount = 0;
        uiManager.UpdateUI(targetCount, collectedCount);
    }

    public void CollectItem()
    {
        if (isGameOver) return;

        collectedCount++;
        uiManager.UpdateUI(targetCount, collectedCount);

        if (collectedCount >= targetCount)
        {
            isGameOver = true;
            uiManager.ShowClearPanel();
        }
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}



