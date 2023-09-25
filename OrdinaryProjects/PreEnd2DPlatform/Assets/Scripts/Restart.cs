using UnityEngine;

public class Restart : MonoBehaviour
{
    private const string Rotation = "Rotation", Position = "Position";

    [SerializeField] private Transform respawnPosition;

    public void RestartPosition(Rigidbody2D player)
    {
            ContainRigidbody(player, Position);
            player.position = respawnPosition.position;
            ContainRigidbody(player);
            ContainRigidbody(player, Rotation);
        
    }



    private void ContainRigidbody(Rigidbody2D player, string key = null)
    {
        switch (key)
        {
            case (Position):
                player.constraints = RigidbodyConstraints2D.FreezePosition;
                break;
            case (Rotation):
                player.constraints = RigidbodyConstraints2D.FreezeRotation;
                break;
            case (null):
                player.constraints = RigidbodyConstraints2D.None;
                break;
        }
    }
}
