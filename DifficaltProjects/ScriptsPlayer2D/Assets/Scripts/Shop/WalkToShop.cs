using UnityEngine;

public class WalkToShop : MonoBehaviour
{
    [SerializeField] private GameObject imageAlarm;
    [SerializeField] private Shop condition;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<PlayerControll>(out _) && condition.GoFurther)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent<PlayerControll>(out _))
        {
            imageAlarm.SetActive(true);
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        imageAlarm.SetActive(false);
    }
}