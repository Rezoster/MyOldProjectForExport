using UnityEngine;

public class Screamer : MonoBehaviour
{
    private const string Condition = "Condition";

    [SerializeField] private Animator scream;
    [SerializeField] private AudioSource screamAudio;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<PlatformEffector2D>(out _))
            scream.SetBool(Condition, true);
    }

    private void ScreamActivate()
    {
        screamAudio.Play();
    }
}
