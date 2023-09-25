using UnityEngine;

[RequireComponent(typeof(InputPlayerControll))]
public class PlayerControll : MonoBehaviour
{
    private const string HorisontAxis = "Horizontal";
    private const string VerticalAxis = "Vertical";
    private const string JumpAxis = "Jump";
    private const string Reload = "r";
    private const string Cling = "q";
    private const string RollUp = "e";

    private const string Floor = "Floor";
    private const string TagCling = "Cling";

    private const int GainJump = 50;

    [SerializeField] private InputPlayerControll inputControll;
    [SerializeField] private NextOrReloadLevel restart;
    [SerializeField] private Rigidbody player;
    [SerializeField] private Checkpoint respawn;
    [SerializeField] private ParticleSystem particleJump;

    private Vector3 direct;

    private float horisontal;
    private float vertical;
    private float jump;

    private bool checkRestart = false;
    private bool checkJump;
    private bool checkCling;
    private bool checkRollUp;
    private bool playerOnTheGround;

    private void Update()
    {
        SettingMovement();
    }


    private void FixedUpdate()
    {
        inputControll.MoveForce(direct, playerOnTheGround);
        Releveling();
    }

    public void RestartCheckpoint(Transform newPosition)
    {
            player.transform.position = newPosition.position;
    }

    private void Releveling()
    {
        if (checkRestart)
            respawn.SavePosition();
    }

    public void Clining()
    {
        if (checkCling)
            player.constraints = RigidbodyConstraints.FreezeRotationY;
    }

    public void RollingUp(GameObject active)
    {
        if (checkRollUp)
            active.SetActive(true);
    }

    private void SettingMovement()
    {
        Inputs();
        ActivateJump();
        direct = new Vector3(horisontal, 0, vertical).normalized;
    }


    private void ActivateJump()
    {
        if (checkJump && playerOnTheGround)
        {
            player.AddForce(new Vector3(0, jump * GainJump, 0), ForceMode.Impulse);
            particleJump.Play();
            playerOnTheGround = false;
        }
    }

    private void Inputs()
    {
        horisontal = Input.GetAxis(HorisontAxis);
        vertical = Input.GetAxis(VerticalAxis);
        checkJump = Input.GetButtonDown(JumpAxis);
        jump = Input.GetAxis(JumpAxis);
        checkRestart = Input.GetKey(Reload);
        checkCling = Input.GetKey(Cling);
        checkRollUp = Input.GetKey(RollUp);
    }

    private void OnCollisionEnter(Collision collision)
    {
        switch (collision.gameObject.tag)
        {
            case Floor:
                playerOnTheGround = true;
                break;
            case TagCling:
                player.constraints = RigidbodyConstraints.FreezePositionY;
                break;
        }

    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag(TagCling))
            player.constraints = RigidbodyConstraints.None;

    }
}
