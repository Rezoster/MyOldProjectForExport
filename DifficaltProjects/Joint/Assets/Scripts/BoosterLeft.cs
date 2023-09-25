using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoosterLeft : MonoBehaviour
{
    [SerializeField] private Collider triger;
    private float interval = 2;
     private bool isActive = false;
    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.name == "Goal")
        {
            collision.rigidbody.velocity = Vector3.left * 100;
            isActive = true;
        }
    }

    private void Blocked()
    {
        if (isActive)
        {
            triger.isTrigger = true;
            interval -= Time.deltaTime;
        }
        if (interval <= 0)
        {
            triger.isTrigger = false;
            interval = 2;
            isActive = false;
        }
    }

    private void FixedUpdate()
    {
        Blocked();
    }
}
