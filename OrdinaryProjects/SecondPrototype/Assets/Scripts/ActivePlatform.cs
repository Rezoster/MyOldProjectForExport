using UnityEngine;
public class ActivePlatform : MonoBehaviour
{
    public const string Player = "Players", Checker = "Checker";

    [SerializeField] private GameObject platform;
    [SerializeField] private Animator activeButton;
    public void ActiveAnimatore(Animator activeAnimation, string nameVarialeble, bool status = true)
    {
        activeAnimation.SetBool(nameVarialeble, status);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag(Player) && !platform.activeSelf)
        {
            platform.SetActive(true);
            ActiveAnimatore(activeButton, Checker);
        }
    }

}
