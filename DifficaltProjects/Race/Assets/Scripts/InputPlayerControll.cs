using UnityEngine;


[RequireComponent(typeof(Rigidbody))]
public class InputPlayerControll : MonoBehaviour
{
    [SerializeField, Range(0, 2000)] private float speed = 200.0f;
    [SerializeField] private Rigidbody player;
    public void MoveForce(Vector3 direction)
    {
        player.AddForce(direction * speed);

    }
}
