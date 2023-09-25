using UnityEngine;
using UnityEngine.SceneManagement;

public class OnMainLevel : MonoBehaviour
{
    public void OnClick()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene(0);
    }
}
