using UnityEngine;
using HVJ;

public class Cling : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player" && CheckTabQ())
        {
            collision.rigidbody.constraints = RigidbodyConstraints.FreezePositionY;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        collision.rigidbody.constraints = RigidbodyConstraints.None;
    }

    private bool CheckTabQ()
    {
        if (Input.GetKey(GlobalAxis.cling))
            return true;
        else return false;
    }
}
