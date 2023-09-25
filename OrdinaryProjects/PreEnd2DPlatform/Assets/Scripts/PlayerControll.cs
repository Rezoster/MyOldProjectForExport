using Unity.VisualScripting;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(InputPlayerControll))]
public class PlayerControll : MonoBehaviour
{

    [Header("Movement vars")]
    [SerializeField] private float jumpForce = 3;
    [SerializeField] private float speed = 5;
    [SerializeField] private bool isGrounded = false;

    [Header("Settings")]
    [SerializeField] private Transform groundColliderTransform;
    [SerializeField] private AnimationCurve curve;
    [SerializeField] private float jumpOffset = 0.2f;
    [SerializeField] private LayerMask groundMask;
    [SerializeField] private Rigidbody2D player;
    [SerializeField] private bool activeRestart;
    [SerializeField] private Transform restartPosition;
    [SerializeField] private Health heal;
    [SerializeField] private Restart restart;
    private Vector3 overlapCirclePosition;




    private void Awake()
    {
        restartPosition.position = player.position;
    }

    public Transform ReturnRestartPosition()
    {
        return restartPosition;
    }

    public void Move(float direction, bool isJumpButtonPressed)
    {
        if (heal.ReturnIsAlive())
        {
            if (isJumpButtonPressed)
                Jump();
            if (Mathf.Abs(direction) > 0.01f)
                HorizontalMovement(direction);
        }
    }

    private void FixedUpdate()
    {
        ActivateRestart();
        overlapCirclePosition = groundColliderTransform.position;
        isGrounded = Physics2D.OverlapCircle(overlapCirclePosition, jumpOffset, groundMask);
    }

    private void ActivateRestart()
    {
        if (activeRestart)
        {
            restart.RestartPosition(player);
            activeRestart = false;
        }
    }

    private void Jump()
    {
        if (isGrounded)
            player.velocity = new Vector2(player.velocity.x, jumpForce);
    }

    private void HorizontalMovement(float direction)
    {
        player.velocity = new Vector2(direction * speed, player.velocity.y);
    }
}