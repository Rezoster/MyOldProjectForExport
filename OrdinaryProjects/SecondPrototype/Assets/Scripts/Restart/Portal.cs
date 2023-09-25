using UnityEngine;

public class Portal : MonoBehaviour
{
    private const string Player = "Players";

    [SerializeField] private LoadLevel loadLevel;
    [SerializeField] private GameObject portalTag;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag(Player))
            loadLevel.LoadingLevel(portalTag.tag);
    }
}
