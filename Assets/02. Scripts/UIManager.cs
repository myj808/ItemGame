
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI countText;
    public GameObject clearPanel;

    public void UpdateUI(int total, int current)
    {
        countText.text = $" 목표 : {total} \n 점수 : {current} ";
    }

    public void ShowClearPanel()
    {
        clearPanel.SetActive(true);
    }

    public void OnRestartButton()
    {
        GameManager.Instance.RestartGame();
    }

    public void OnExitButton()
    {
        GameManager.Instance.ExitGame();
    }
}


