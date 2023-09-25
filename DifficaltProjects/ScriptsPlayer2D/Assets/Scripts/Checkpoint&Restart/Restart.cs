using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    private int thisScene;

    private void Awake()
    {
        thisScene = SceneManager.GetActiveScene().buildIndex;
    }

    public void Reload(int scene = 0)
    {
        SceneManager.LoadScene(scene + thisScene);
    }
}
