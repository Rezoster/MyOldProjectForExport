using UnityEngine;


[RequireComponent(typeof(Rigidbody2D))]
public class InputPlayerControll : MonoBehaviour
{
    [SerializeField] private Rigidbody2D player;

    public void MoveForce(Vector3 direction)
    {
        player.AddForce(direction);
    }
}
