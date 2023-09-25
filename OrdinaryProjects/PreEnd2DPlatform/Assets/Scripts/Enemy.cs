using System;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private const string Condition = "Condition";
    private const byte AttackPower = 3;

    [SerializeField] private LayerMask player;
    [SerializeField] private Animator atack;
    private Health damage;
    private GameObject playerCollision;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        playerCollision = collision.gameObject;
        if (playerCollision.layer == SeachNumberLayer(player.value))
        {
            damage = playerCollision.GetComponent<Health>();
            atack.SetBool(Condition, true);
            damage.Damage(40);
            collision.attachedRigidbody.velocity = collision.transform.right * AttackPower;
        }
    }

    private void DisactivateAnimationAttackCrow()
    {
        atack.SetBool(Condition, false);
    }

    private int SeachNumberLayer(int layer)
    {
        int returnNumberLayer = 0;
        for (int i = 0; layer != 1; i++)
        {
            layer /= 2;
            returnNumberLayer = i;
        }
        returnNumberLayer++;
        return returnNumberLayer;
    }
}
