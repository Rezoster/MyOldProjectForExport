using UnityEngine;


[RequireComponent(typeof(Rigidbody))]
public class InputPlayerControll : MonoBehaviour
{
    [SerializeField] private Rigidbody player;
    private readonly float speed = 200.0f;

    public void MoveForce(Vector3 direction, bool onGround)
    {
        if (onGround)
            player.AddForce(direction * speed);
    }
}
