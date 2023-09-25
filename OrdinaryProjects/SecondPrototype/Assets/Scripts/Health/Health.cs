using UnityEngine;

public class Health : MonoBehaviour
{
    private const byte SmallDamage = 75;
    private const byte MiddleDamage = 50;
    private const byte BigDamage = 50;


    [SerializeField] private Material player;
    [SerializeField] private Checkpoint respawn;
    [SerializeField] private Material smallDamage;
    [SerializeField] private Material middleDamage;
    [SerializeField] private Material bigDamage;
    [SerializeField] private float health;
    private readonly float healthFull = 100.0f;
    private void Start()
    {
        health = healthFull;
    }

    public void Damage(float damage = 10.0f)
    {
        health -= damage;
    }

    public void InstantDeath()
    {
        health = 0;
    }

    public void Healing()
    {
        health = healthFull;   
    }

    private void CheckLose()
    {
        if (health <= SmallDamage)
            player.color = smallDamage.color;
        if (health <= MiddleDamage)
            player.color = middleDamage.color;
        if(health <= BigDamage)
            player.color = bigDamage.color;
        if (health <= 5)
            respawn.SavePosition();
    }

    private void CheckedHealth()
    {
        if (health <= 0)
            health = 0;
        if (health >= healthFull)
            health = healthFull;
    }
    private void FixedUpdate()
    {
       // health += 0.05f;
        CheckLose();
        CheckedHealth();
    }
}
