using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangedScene : MonoBehaviour
{
    private int sceneIndex;

    private void Start()
    {
        sceneIndex = SceneManager.GetActiveScene().buildIndex;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("DeathZone"))
        {
            if (sceneIndex + 1 != SceneManager.sceneCountInBuildSettings)
                SceneManager.LoadScene(sceneIndex + 1);
            else
            {
                SceneManager.LoadScene(0);
                sceneIndex = 0;
            }
        }
    }
}
