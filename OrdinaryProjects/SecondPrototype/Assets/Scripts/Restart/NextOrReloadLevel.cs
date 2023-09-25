using UnityEngine;
using UnityEngine.SceneManagement;

public class NextOrReloadLevel : MonoBehaviour
{
    [SerializeField] private PlayerControll loadScene;
    [SerializeField] private GameObject camers;
    private int childNumber;

    private void Start()
    {
        childNumber = camers.transform.childCount;
        SetActivateCamera();
    }

    public void Restart(int anotherScene = 0)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + anotherScene);
    }

    public void OnClickStartGame()
    {
        Restart(1);
    }

    public void OnClickTrainigLevel()
    {
        Restart(5);
    }

    public void CentralLevel()
    {
        SceneManager.LoadScene(1);
    }

    private void SetActivateCamera()
    {
        for(int i = 1; i < childNumber; i++)
        {
            camers.transform.GetChild(i).gameObject.SetActive(false);
        }

    }

    private void ActivateCamera()
    {

    }
}
