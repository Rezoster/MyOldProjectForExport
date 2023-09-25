using JetBrains.Annotations;
using UnityEngine;

public class PauseController : MonoBehaviour
{
    private bool paused;
    public GameObject PausePanel;

    public void PauseGame()
    {
        Time.timeScale = 0;
        PausePanel.SetActive(true);
        paused = !paused;
    }

    public void ContinueGame()
    {
        Time.timeScale = 1;
        PausePanel.SetActive(false);
        paused = !paused;
    }
}
