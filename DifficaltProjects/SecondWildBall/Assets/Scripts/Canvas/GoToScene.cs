using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToScene : MonoBehaviour
{
    [SerializeField] private GameObject buttonGameObjectName;
    [SerializeField] private GameObject buttons;
    [SerializeField] private string buttonName;

    private void Distribution()
    {
        buttonName = buttonGameObjectName.name;
        for (int i = 0; i < buttons.transform.hierarchyCount; i++)
        {
            NewScene(i);
        }

    }

    private void NewScene(int needNumberScene)
    {
        if ($"ButtonToLevel{needNumberScene}" == buttonName)
        {
            SceneManager.LoadScene(needNumberScene);

        }
    }

    public void OnClick()
    {
        Distribution();
    }
}
