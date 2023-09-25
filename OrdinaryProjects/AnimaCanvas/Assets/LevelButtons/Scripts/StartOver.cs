using UnityEngine.SceneManagement;
using UnityEngine;

public class StartOver : MonoBehaviour
{
    
    public void OnClick()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
