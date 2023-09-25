using UnityEngine;

public class DeathZone : MonoBehaviour
{
    [SerializeField] private PlayerControll restartPosition;
    [SerializeField] private Restart restart;
    private GameObject player;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        player = collision.gameObject;
        if (player.TryGetComponent<PlayerControll>(out _) && player.TryGetComponent<Rigidbody2D>(out Rigidbody2D settingContain))
        {
            restart.RestartPosition(settingContain);
            InputPlayerControll setDead = new();
            setDead.SetStatusLife();
        }
    }
}
