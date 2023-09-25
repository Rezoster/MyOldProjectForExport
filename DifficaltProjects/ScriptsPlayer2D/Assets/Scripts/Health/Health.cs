using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private int maxHealth = 100;
    [SerializeField] private int health;

    private Restart reloadScene;

    public bool IsAlive => health > 0;

    private void Awake()
    {
        health = maxHealth;
    }

    public void Damage(int damage = 30)
    {
        health -= damage;
        CheckAlive();
        if (!IsAlive)
            SceneLoad();
    }

    public void KillOrResurrection(bool ressuredHim)
    {
        if (ressuredHim)                                 //Воскресить 
            health = maxHealth;
        else
            health = 0;                             //Убить

    }

    public int ReturnHealth()
    {
        return health;
    }

    private void SceneLoad()
    {
        if (gameObject.TryGetComponent<PlayerControll>(out _) && gameObject.TryGetComponent<Health>(out _))
        {
            reloadScene = FindObjectOfType<Restart>();
            reloadScene.Reload();
        }
        else
            Destroy(gameObject);
    }

    private void CheckAlive()
    {
        if (health < 0)
            health = 0;
    }
}
