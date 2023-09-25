using UnityEngine;

public class Health : MonoBehaviour
{
    private const int maxHealth = 400;

    [SerializeField] private int health;
    private bool isAlive;
    public void Damage(int damage = 30)
    {
        health -= damage;
        CheckAlive();
        if (!isAlive)
            Destroy(gameObject);

    }

    public void DamageForPlayer(int damagePlayer = 15, bool momentKill = false)
    {
        if (momentKill)
            health = 0;
        else
            health -= damagePlayer;
        CheckAlive();
        if (!isAlive)
        {
            InputPlayerControll dead = new();
            Debug.Log(3);
            dead.SetStatusLife();
        }
            
    }

    public int ReturnHealth()
    {
        return health;
    }

    public bool ReturnIsAlive()
    {
        return isAlive;
    }

    private void Awake()
    {
        isAlive = true;
        health = maxHealth;
    }

    private void CheckAlive()
    {
        if (health > 0)
            isAlive = true;
        else
            isAlive = false;
    }
}
