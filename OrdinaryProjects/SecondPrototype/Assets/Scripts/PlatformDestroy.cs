using UnityEngine;

public class Laver : MonoBehaviour
{
    private const string Player = "Players", Checker = "Checker";
    [SerializeField] private ActivePlatform activeAvimation;
    [SerializeField] private Animator downLever;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag(Player))
        {
            activeAvimation.ActiveAnimatore(downLever, Checker);
        }
    }
}
