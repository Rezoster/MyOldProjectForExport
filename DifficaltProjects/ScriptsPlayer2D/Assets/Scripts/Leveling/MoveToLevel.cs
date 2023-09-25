using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveToLevel : MonoBehaviour
{
    [SerializeField] private int m_Level;

    public void OnButtonClick()
    {
        SceneManager.LoadScene(m_Level);
    }
}
