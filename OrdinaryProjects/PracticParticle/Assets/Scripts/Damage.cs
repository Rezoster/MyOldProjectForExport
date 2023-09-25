using UnityEngine;

public class Damage : MonoBehaviour
{
    [SerializeField] private ParticleSystem blood;
    [SerializeField] private Collider spike;

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(1);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other == spike)
            blood.Play();
        Debug.Log(2);
    }
}
