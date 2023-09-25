using UnityEngine;

public class CentreBlood : MonoBehaviour
{
    [SerializeField] private Transform player;

    private void FixedUpdate()
    {
        transform.position = player.position;
    }
}
