using UnityEngine;

public class Elevatore : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        SetCollision(collision,true);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        SetCollision(collision);
    }

    private void SetCollision(Collider2D collision, bool activeMotore = false)
    {
        if(collision.gameObject.TryGetComponent<SliderJoint2D>(out SliderJoint2D motore))
        SelectSlider(motore, activeMotore);
    }

    private void SelectSlider(SliderJoint2D motore, bool playerOnPlatform = false)
    {
        JointMotor2D changeMotor = motore.motor;
        changeMotor.motorSpeed = ChangedMotorSign(playerOnPlatform);
        motore.motor = changeMotor;
    }

    private int ChangedMotorSign(bool playerOnPlatform = false)
    {
        if (playerOnPlatform)
            return -1;
        else
            return 1;
    }
}
