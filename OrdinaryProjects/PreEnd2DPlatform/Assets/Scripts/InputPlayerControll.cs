using UnityEngine;


[RequireComponent(typeof(PlayerControll))]
public class InputPlayerControll : MonoBehaviour
{
    private const string HORIZONTAL = "Horizontal";
    private const string JUMP = "Jump";
    private const string FIRE = "Fire1";

    [SerializeField] private PlayerControll playerControll;
    [SerializeField] private float horizontalDirection;
    private bool isJumpButtonPressed;
    private bool isFireButtonPressed;
    private bool isDead = true;

    public bool ReturnFireButtonPressed()
    {
        return isFireButtonPressed;
    }

    public float ReturnHORIZOMTAL()
    {
        return horizontalDirection;
    }

    public void SetStatusLife()
    {
        Debug.Log(1);
        isDead = false;
        gameObject.transform.rotation = Quaternion.Euler(0, 0, 90);
    }

    private void Update()
    {
        Inputs();
        playerControll.Move(horizontalDirection, isJumpButtonPressed);
    }

    private void Inputs()
    {
        if (isDead)
        {
            horizontalDirection = Input.GetAxisRaw(HORIZONTAL);
            isJumpButtonPressed = Input.GetButtonDown(JUMP);
            isFireButtonPressed = Input.GetButtonDown(FIRE);
        }
    }
}