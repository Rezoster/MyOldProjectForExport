using UnityEngine;
using UnityEngine.UI;

public class ChangeSkin : MonoBehaviour
{
    [SerializeField] private GameObject skin;
    [SerializeField] private Image[] ColorList;
    public void OnClick()
    {
        Time.timeScale = 1.0f;

    }

    private void SetColor()
    {
        
    }
}
