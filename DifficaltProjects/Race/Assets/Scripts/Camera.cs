using UnityEngine;

public class Camera : MonoBehaviour
{
    [SerializeField] private Transform playerPosition;
    private Vector3 distance;

    private void Start()
    {
        distance = transform.position - playerPosition.position;
    }

    private void FixedUpdate()
    {
        transform.position = distance + playerPosition.position;
    }
}
