using UnityEngine;

public class ControllerBall : MonoBehaviour
{
    [SerializeField] private Transform ball;
    [SerializeField] private Transform goal;
    [SerializeField] private Transform arrow;
    [SerializeField] private Rigidbody ballRigid;
    [SerializeField] private bool changeActiveBall = false;
    [SerializeField] private bool changeStrongeBall = false;
    [SerializeField] private float directionArrow;
    [SerializeField] private float strong;
    private Vector3 vec;
    private void Start()
    {
        print("Чтобы изменить направление, надо включить changeActiveBall");
        print("Чтобы применить силу, надо включить changeStrongeBall");
    }

    private void print(string str)
    {
        Debug.Log(str);
    }

    private void StartBall()
    {
        if (changeStrongeBall)
            ApplyingForceToTheBall();
        if (changeActiveBall)
        {
            ball.Rotate(0, directionArrow, 0);
        }

    }    

    private void ApplyingForceToTheBall()
    {
        vec *= strong * 10;
        ballRigid.AddForce(-vec.x, 0, -vec.z);
        TestingStrongBall();
    }

    private void ModuleNumber()
    {
        if (directionArrow > 50 || directionArrow < -50)
            directionArrow = 0;
        if (strong < 0)
            strong = 0;
    }

    private void TestingStrongBall()
    {
        if (strong == 0)
            changeStrongeBall = false;
        if (changeStrongeBall && strong > 0)
        {
            directionArrow = 0;
            strong = 0;
            changeActiveBall = false;
            changeStrongeBall = false;
        }
    }

    void FixedUpdate()
    {
        Time.timeScale = 10;
        vec = goal.position;
        ModuleNumber();
        StartBall();
        TestingStrongBall();
    }
}
