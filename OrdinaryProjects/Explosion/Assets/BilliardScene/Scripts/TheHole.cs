using UnityEngine;

public class TheHole : MonoBehaviour
{
    [SerializeField] private Transform balls;
    [SerializeField] private Transform creatingPositionForBalls;

    private void OnCollisionEnter(Collision collision)
    {
        for (int i = 1; i < balls.childCount + 1; i++)
            if (collision.gameObject.name == $"Ball_{i}")
                CreatingPositionForBalls(creatingPositionForBalls, collision);
    }

    private void CreatingPositionForBalls(Transform positionBalls, Collision collisionBalls)
    {
        collisionBalls.transform.position = positionBalls.position;
        collisionBalls.rigidbody.velocity = Vector3.forward;


    }
}
