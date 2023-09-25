using UnityEngine;

public class Bullet : MonoBehaviour
{
    private const byte LifePath = 1;

    [SerializeField] private LayerMask personLayer;
    
    private Health callDamage;
    private GameObject enemy;

    private void Awake()
    {
        Destroy(gameObject, LifePath);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        enemy = collision.gameObject;
        if (enemy.layer != personLayer.value && enemy.TryGetComponent<Health>(out _)) {
            callDamage = enemy.GetComponent<Health>();
            callDamage.Damage(30);
            Destroy(gameObject);
        }
    }
}
