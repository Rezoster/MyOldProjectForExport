using UnityEngine;


[RequireComponent(typeof(PlayerControll))]
public class InputPlayerControll : MonoBehaviour
{
    private const string horizontal = "Horizontal";
    private const string Jump = "Jump";
    private const string Fire = "f";
    private const string Interaction = "e";

    [SerializeField] private PlayerControll playerControll;

    public bool DirectionOfView_Up => HorizontalDirection > 0;
    public bool DirectionOfView_Low => HorizontalDirection < 0;
    public bool IsInteractionButtonPressed { get; private set; }
    public float HorizontalDirection { get; private set; }
    public bool IsFireButtonPressed { get; private set; }
    private bool isJumpButtonPressed;

    private void Update()
    {
        Inputs();
        playerControll.Move(HorizontalDirection, isJumpButtonPressed);
    }

    private void Inputs()
    {
        HorizontalDirection = Input.GetAxisRaw(horizontal);
        isJumpButtonPressed = Input.GetButtonDown(Jump);
        IsFireButtonPressed = Input.GetKey(Fire);
        IsInteractionButtonPressed = Input.GetKey(Interaction);
    }
}