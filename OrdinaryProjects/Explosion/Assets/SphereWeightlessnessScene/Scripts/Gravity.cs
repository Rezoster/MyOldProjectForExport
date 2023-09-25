using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        other.attachedRigidbody.useGravity = false;
    }

    private void OnTriggerExit(Collider other)
    {
        other.attachedRigidbody.useGravity = true;
        other.attachedRigidbody.AddForce(-10, 0, 0, ForceMode.Impulse);
    }
}
