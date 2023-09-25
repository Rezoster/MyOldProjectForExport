using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private Animator heal;
    [SerializeField] private GameObject activeParticle;
    private void OnCollisionEnter(Collision collision)
    {
        heal.SetBool("Condition", true);
        activeParticle.SetActive(true);
    }

    private void Destroyed()
    {
        Destroy(gameObject);
    }
}
