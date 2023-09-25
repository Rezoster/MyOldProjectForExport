using UnityEngine;

public class ActivateAudioTrigger : MonoBehaviour
{
    [SerializeField] private AudioSource sound;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent<PlayerControll>(out _))
            sound.Play();
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent<PlayerControll>(out _))
            sound.Pause();
    }
}
