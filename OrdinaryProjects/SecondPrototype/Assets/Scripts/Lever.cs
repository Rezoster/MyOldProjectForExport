using UnityEngine;

public class Lever : MonoBehaviour
{
    private const string Player = "Players", Checker = "Checker";
    [SerializeField] private ActivePlatform activeAvimation;
    [SerializeField] private Animator downPlatform;
    [SerializeField] private GameObject platforms;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag(Player))
        {
            activeAvimation.ActiveAnimatore(downPlatform, Checker);
            platforms.SetActive(true);
        }
    }
}
