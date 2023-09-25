using UnityEngine;

public class ChangeCamera : MonoBehaviour
{
    [SerializeField] private GameObject firstCamera;
    [SerializeField] private GameObject secondCamera;

    public void OnClick()
    {
        if (firstCamera.activeSelf)
        {
            firstCamera.SetActive(false);
            secondCamera.SetActive(true);
        }
        else
        {
            firstCamera.SetActive(true);
            secondCamera.SetActive(false);
        }
    }
}
