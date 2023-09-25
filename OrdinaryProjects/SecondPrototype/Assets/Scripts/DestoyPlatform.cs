using UnityEngine;

public class DestoyPlatform : MonoBehaviour
{
    private const string Player = "Players", Checker = "Checker";
    [SerializeField] private ActivePlatform activeAvimation;
    [SerializeField] private Animator downPlatform;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag(Player))
        {
            activeAvimation.ActiveAnimatore(downPlatform, Checker);
        }
    }

   
}
