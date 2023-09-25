using UnityEngine;

[RequireComponent(typeof(InputPlayerControll))]
public class PlayerControll : MonoBehaviour
{
    private const string HorisontAxis = "Horizontal";
    private const string JumpAxis = "Jump";
    private const string ShiftAxis = "Fire3";
    private const string AttackAxis = "Jump";

    private const string activeJump = "isJump", activeRun = "isRun", activeMoving = "isMoving";             //Движение
    private const string activeStay = "isStay", activeStayLongTime = "isStayLongTime";                      //Покой
    private const string activeDie = "isDie", activeAttack = "isAttack", activeAnotherDie = "isAnothDie";   //Атака и смерть

    private const int GainJump = 5;
    private const int GainRun = 20;

    [SerializeField] private InputPlayerControll inputControll;
    [SerializeField] private Rigidbody2D player;
    [SerializeField] private Animator activateAnimations;

    private Vector3 direct;

    [SerializeField] private float horisontal;
    private float jump;

    private bool checkJump;
    private bool checkRun;
    private bool checkAttack;
    private bool checkRunForMoving = true;

    private void Update()
    {
        SettingMovement();
        if (checkAttack)
            Debug.Log(1);
    }

    private void FixedUpdate()
    {
        inputControll.MoveForce(direct);
        Running();
    }


    private void SettingMovement()
    {
        Inputs();
        ActivateJump();
        direct = new Vector3(horisontal, 0, 0).normalized;
        ActivateStayAnimation();
        if (horisontal > 0 && checkRunForMoving)
        {
            ActivateAnimation(activeMoving);
        }

    }
    private void Running()
    {
        if (checkRun)
        {
            checkRunForMoving = false;
            DisactivateAnimation(activeMoving);
            ActivateAnimation(activeRun);
            direct *= GainRun;
        }
        if (player.velocity.magnitude < 1)
        {
            direct = new Vector3(horisontal, 0, 0).normalized;
            DisactivateAnimation(activeRun);
            ActivateAnimation(activeMoving);
        }
    }

    public void OnClick()
    {
        Debug.Log(1111);
    }

    private void ActivateStayAnimation()
    {
        if (player.velocity.magnitude < 0.1 && !checkRun)
        {
            DisactivateAllAnimation();
            activateAnimations.SetBool(activeStay, true);
        }
    }

    private void DisactivateAnimation(string animation)
    {
        activateAnimations.SetBool(animation, false);
    }

    private void DisactivateAllAnimation()
    {
        DisactivateAnimation(activeAttack);
        DisactivateAnimation(activeJump);
        DisactivateAnimation(activeMoving);
        DisactivateAnimation(activeStayLongTime);
        DisactivateAnimation(activeRun);
    }

    private void ActivateAnimation(string animation)
    {
        activateAnimations.SetBool(animation, true);
        DisactivateAnimation(activeStay);
    }


    private void ActivateJump()
    {
        if (checkJump)
        {
            player.AddForce(new Vector3(0, jump * GainJump, 0), ForceMode2D.Impulse);
        }
    }

    private void Inputs()
    {
        horisontal = Input.GetAxis(HorisontAxis);
        checkJump = Input.GetButtonDown(JumpAxis);
        checkRun = Input.GetButtonDown(ShiftAxis);
        checkAttack = Input.GetButtonDown(AttackAxis);
        jump = Input.GetAxis(JumpAxis);
    }
}
