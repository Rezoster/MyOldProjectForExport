using UnityEngine;

public class Bullet : MonoBehaviour
{
    private const byte LifePath = 1;

    private Health callDamage;
    [SerializeField] private LayerMask personLayer;
    private GameObject enemy;

    private void Awake()
    {
        Destroy(gameObject, LifePath);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        enemy = collision.gameObject;
        if ((enemy.layer != personLayer.value)) {
            callDamage = enemy.GetComponent<Health>();
            callDamage.Damage(30);
            Destroy(gameObject);
        }
    }
}
