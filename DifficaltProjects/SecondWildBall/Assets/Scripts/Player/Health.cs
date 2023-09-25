using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    [SerializeField] private Image healthImage;
    [SerializeField] private GameObject lose;
    private float health;
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
        if (health <= 5)
            lose.SetActive(true);
    }

    private void CheckedHealth()
    {
        if (health <= 0)
            health = 0;
        if (health >= 100.0f)
            health = 100.0f;
    }
    private void FixedUpdate()
    {
        health += 0.05f;
        healthImage.fillAmount = health / healthFull;
        CheckLose();
        CheckedHealth();
    }
}
