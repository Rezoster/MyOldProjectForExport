using UnityEngine;
using static UnityEngine.ParticleSystem;

public class ChangedBalls : MonoBehaviour
{
    [SerializeField] private GameObject ball;
    [SerializeField] private Rigidbody ballSpeed;
    [SerializeField] private GameObject particles;
    private void ChangedPrefabs()
    {
        if (ballSpeed.velocity.x > 0 && ballSpeed.velocity.z > 0)
        {
            particles.SetActive(true);
        }
        else particles.SetActive(false);

    }
    void FixedUpdate()
    {
        ChangedPrefabs();
    }
}
