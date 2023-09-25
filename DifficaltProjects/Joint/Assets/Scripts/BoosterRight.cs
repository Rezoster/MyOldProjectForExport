using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoosterRight : MonoBehaviour
{

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.name == "Goal")
        {
            collision.rigidbody.velocity = Vector3.right * 50;
        }
    }
}
