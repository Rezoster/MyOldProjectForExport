using UnityEngine;

public class MenuPause : MonoBehaviour
{
    [SerializeField] private GameObject imageMenuSetting;

    private void Awake()
    {        
        imageMenuSetting.SetActive(false);
        Time.timeScale = 1f;
    }

    public void TimeStop()
    {
        imageMenuSetting.SetActive(true);
        Time.timeScale = 0f;
    }

    public void TimeLater()
    {
        imageMenuSetting.SetActive(false);
        Time.timeScale = 1f;
    }
}
