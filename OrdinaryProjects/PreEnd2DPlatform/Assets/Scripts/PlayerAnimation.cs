using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    private const string isMoving = "isMoving";
    private const string isStay = "isStay";

    [SerializeField] private Animator statusMove;
    [SerializeField] private InputPlayerControll horizontal;

    private void Update()
    {
        AnimationMove();
    }

    private void AnimationMove()
    {
        if (horizontal.ReturnHORIZOMTAL() != 0)
        {
            statusMove.SetBool(isMoving, true);
            statusMove.SetBool(isStay, false);
        }
        else
        {
            statusMove.SetBool(isMoving, false);
            statusMove.SetBool(isStay, true);
        }
    }
}
