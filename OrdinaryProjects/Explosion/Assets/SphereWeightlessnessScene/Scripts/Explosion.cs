using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    [SerializeField] private Transform centreExplosion;
    [SerializeField] private Rigidbody[] objectsOfExplosion;
    [SerializeField] private bool activateExplosion;
    [SerializeField] private float intervalTime = 5;
    private float distance;
    private float radius = 90;

    private void ExplosionDistance(Rigidbody rigidbody)
    {
        distance = radius - Vector3.Distance(centreExplosion.position, rigidbody.position);
        rigidbody.AddForce(distance, distance, distance, ForceMode.Impulse);
    }

    private void ExplosionRigidbody()
    {
        for (int i = 0; i < objectsOfExplosion.Length; i++)
            ExplosionDistance(objectsOfExplosion[i]);
        intervalTime = 5;

    }
    void FixedUpdate()
    {
        if (activateExplosion)
        {
            intervalTime -= Time.deltaTime;
            if (intervalTime <= 0)
                ExplosionRigidbody();
        }
    }
}
