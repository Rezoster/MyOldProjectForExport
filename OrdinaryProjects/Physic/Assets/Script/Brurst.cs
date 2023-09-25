//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class Brurst : MonoBehaviour
{
    [SerializeField] private Transform boom;
    [SerializeField] private bool timeActive = true;
    [SerializeField] private float timeToExplosion;
    [SerializeField] private float radius;
    [SerializeField] private float power;

    private void ExplosionArray(Rigidbody rb)
    {
        float distance = Vector3.Distance(boom.position, rb.transform.position);
        if (distance < radius)
        {
            Vector3 difference = rb.transform.position - boom.position;
            rb.AddForce(difference.normalized * power * (radius - distance), ForceMode.Impulse);
        }
    }

    private void Explosion()
    {
        Rigidbody[] rigidbodies = FindObjectsOfType<Rigidbody>();

        foreach (Rigidbody rb in rigidbodies)
            ExplosionArray(rb);

        timeToExplosion = 4;
    }



    void FixedUpdate()
    {
        if(timeActive)
            timeToExplosion -= Time.deltaTime;

        if (timeToExplosion <= 1)
        {
            Explosion();
        }

    }
}
