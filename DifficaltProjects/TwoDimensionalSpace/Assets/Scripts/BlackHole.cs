using UnityEngine;

public class BlackHole : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent<Rigidbody2D>(out Rigidbody2D offObj))
        {
            TurnOffObject(offObj.gameObject);
        }
    }

    private void TurnOffObject(GameObject offObj)
    {
        Destroy(offObj, 3);
    }
}
