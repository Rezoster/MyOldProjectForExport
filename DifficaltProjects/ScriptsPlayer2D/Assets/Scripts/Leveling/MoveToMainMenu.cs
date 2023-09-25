using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveToMainMenu : MonoBehaviour
{
    public void OnClick()
    {
        SceneManager.LoadScene(0);
    }
}
