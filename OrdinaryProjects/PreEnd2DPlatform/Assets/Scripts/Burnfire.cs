using UnityEngine;

public class Burnfire : MonoBehaviour
{
    private Health damage;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        damage = collision.gameObject.GetComponent<Health>();
        if (!TryGetComponent<InputPlayerControll>(out _))
            damage.Damage(20);
        else
            damage.DamageForPlayer();
    }
}
