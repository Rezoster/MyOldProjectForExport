using UnityEngine;

public class Death : MonoBehaviour
{
    [SerializeField] private CreatTimers timer;
    [SerializeField] private ActiveHeal heal;
    [SerializeField] private Health damage;
    private const int caruseil = 3;
    private const int hammer = 6;
    private const int gate = 7;
    private const int axe = 8;
    private const int deathZone = 9;
    private const int knife = 11;
    private const int health = 12;
    private const int endLevel = 13;
    private int layerAttackedPlayer;

    private void OnCollisionEnter(Collision collision)
    {
        layerAttackedPlayer = collision.gameObject.layer;
        switch (layerAttackedPlayer)
        {
            case caruseil:
            case gate:
                timer.HitGate();
                break;

            case knife:
                damage.Damage(50);
                break;

            case hammer:
            case axe:
            case deathZone:
                damage.InstantDeath();
                break;

            case health:
                heal.ActivateSkipAnimation(true);
                break;

        }
    }

}
