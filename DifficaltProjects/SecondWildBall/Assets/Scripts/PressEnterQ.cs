using UnityEngine;
using UnityEngine.UI;

public class PressEnterQ : MonoBehaviour
{
    [SerializeField] private Text pleasePress;

    private void OnTriggerEnter(Collider other)
    {
        Activate(true);
        pleasePress.text = "Please, hold down the \"E\", near blue platform, to cling on her";
    }

    private void OnTriggerExit(Collider other)
    {
        Activate();
    }

    private void Activate(bool active = false)
    {
        pleasePress.gameObject.SetActive(active);
    }
}
