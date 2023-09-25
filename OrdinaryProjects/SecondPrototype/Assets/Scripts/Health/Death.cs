using UnityEngine;

public class Death : MonoBehaviour
{
    [SerializeField] private Health damage;
    [SerializeField] private CreatTimers timer;
    private const string Caruseil = "Caruseil";
    private const string Gate = "Gate";
    private const string Knife = "Knife";
    private const string Hammer = "Hammer";
    private const string Axe = "Axe";
    private const string DeathZone = "DeathZone";
    private string layerAttackedPlayer;

    private void OnCollisionEnter(Collision collision)
    {
        layerAttackedPlayer = collision.gameObject.tag;
        switch (layerAttackedPlayer)
        {
            case Caruseil:
            case Gate:
                timer.HitGate();
                break;

            case Axe:
            case Knife:
                damage.Damage(50);
                break;

            case Hammer:
            case DeathZone:
                damage.InstantDeath();
                break;
        }
    }

}
