using UnityEngine;
using UnityEngine.SceneManagement;

public class Checkpoint : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private int index;
    [SerializeField] private bool trigger;

    private void Awake()
    {
        if (DataConteiner.checkpointIndex == index)
        {
            player.position = transform.position;
            Debug.Log(1);
        }
    }

    private void FixedUpdate()
    {
        if (trigger)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent<PlayerControll>(out _) && index > DataConteiner.checkpointIndex)
        {
            DataConteiner.checkpointIndex = index;
            Debug.Log(2);
        }
    }
}
