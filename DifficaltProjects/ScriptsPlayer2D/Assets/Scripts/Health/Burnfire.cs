using UnityEngine;

public class Burnfire : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent<Health>(out var health))
            health.Damage(20);
    }
}
